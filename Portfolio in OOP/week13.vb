Imports System.Data
Imports MySqlConnector

Public Class week13
    Private Const ServerConnectionString As String = "Server=127.0.0.1;Port=3306;User ID=root;Password=;"
    Private Const DatabaseName As String = "farm_db"
    Private crops As DataTable

    Private Function DatabaseConnectionString() As String
        Return ServerConnectionString & "Database=" & DatabaseName & ";"
    End Function

    Private Sub week13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set parenting for proper WinForms transparency over PictureBoxes
        lbl1.Parent = pb2
        lbl2.Parent = pb2
        lbl3.Parent = pb2
        lbl4.Parent = pb2
        lbl5.Parent = pb2
        lbl6.Parent = pb2
        lbl7.Parent = pb2
        txtCropId.Parent = pb2
        txtType.Parent = pb2
        txtCropName.Parent = pb2
        txtSeedCost.Parent = pb2
        txtGrowth.Parent = pb2
        txtSellCost.Parent = pb2
        btnCreate.Parent = pb2
        btnRead.Parent = pb2
        btnUpdate.Parent = pb2
        btnDelete.Parent = pb2

        lbl8.Parent = pb1
        DataGridView1.Parent = pb1

        ConfigureGrid()

        Try
            InitializeDatabase()
            LoadCrops()
        Catch ex As Exception
            ShowDatabaseError(ex)
        End Try
    End Sub

    Private Sub ConfigureGrid()
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowHeadersVisible = False
        DataGridView1.BackgroundColor = Color.NavajoWhite
        DataGridView1.GridColor = Color.Tan
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.EnableHeadersVisualStyles = False

        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BlanchedAlmond
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Brown
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("rainyhearts", 13.0F, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
        DataGridView1.DefaultCellStyle.ForeColor = Color.Brown
        DataGridView1.DefaultCellStyle.Font = New Font("rainyhearts", 12.0F, FontStyle.Regular)
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Sienna
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub InitializeDatabase()
        Using connection As New MySqlConnection(ServerConnectionString)
            connection.Open()
            Using command As New MySqlCommand("CREATE DATABASE IF NOT EXISTS `" & DatabaseName & "` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci", connection)
                command.ExecuteNonQuery()
            End Using
        End Using

        Using connection As New MySqlConnection(DatabaseConnectionString())
            connection.Open()
            Const sql As String = "CREATE TABLE IF NOT EXISTS crops (" &
                "crop_id INT(11) NOT NULL PRIMARY KEY, " &
                "crop_name VARCHAR(50) NOT NULL, " &
                "`type` VARCHAR(50) NOT NULL, " &
                "seed_cost DECIMAL(7,2) NOT NULL DEFAULT 0.00, " &
                "growth INT(11) NOT NULL DEFAULT 0, " &
                "sell_cost DECIMAL(7,2) NOT NULL DEFAULT 0.00" &
                ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4"
            Using command As New MySqlCommand(sql, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub LoadCrops(Optional whereClause As String = "", Optional parameters As List(Of MySqlParameter) = Nothing)
        Using connection As New MySqlConnection(DatabaseConnectionString())
            connection.Open()
            Dim sql As String = "SELECT crop_id AS `Crop ID`, `type` AS `Type`, crop_name AS `Crop Name`, " &
                                "seed_cost AS `Seed Cost`, growth AS `Days of Growth`, sell_cost AS `Sell Cost` " &
                                "FROM crops"
            If Not String.IsNullOrWhiteSpace(whereClause) Then
                sql &= " WHERE " & whereClause
            End If
            sql &= " ORDER BY crop_id ASC"

            Using command As New MySqlCommand(sql, connection)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        command.Parameters.Add(p)
                    Next
                End If

                Using adapter As New MySqlDataAdapter(command)
                    crops = New DataTable()
                    adapter.Fill(crops)
                End Using
            End Using
        End Using

        DataGridView1.DataSource = crops
        If DataGridView1.Columns.Contains("Seed Cost") Then
            DataGridView1.Columns("Seed Cost").DefaultCellStyle.Format = "N2"
        End If
        If DataGridView1.Columns.Contains("Sell Cost") Then
            DataGridView1.Columns("Sell Cost").DefaultCellStyle.Format = "N2"
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If String.IsNullOrWhiteSpace(txtCropName.Text) OrElse String.IsNullOrWhiteSpace(txtType.Text) Then
            MessageBox.Show("Please enter both Crop Name and Type.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim seedCost As Decimal = 0D
        If Not String.IsNullOrWhiteSpace(txtSeedCost.Text) AndAlso Not Decimal.TryParse(txtSeedCost.Text.Trim(), seedCost) Then
            MessageBox.Show("Seed Cost must be a valid number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim growth As Integer = 0
        If Not String.IsNullOrWhiteSpace(txtGrowth.Text) AndAlso Not Integer.TryParse(txtGrowth.Text.Trim(), growth) Then
            MessageBox.Show("Days of Growth must be a whole number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sellCost As Decimal = 0D
        If Not String.IsNullOrWhiteSpace(txtSellCost.Text) AndAlso Not Decimal.TryParse(txtSellCost.Text.Trim(), sellCost) Then
            MessageBox.Show("Sell Cost must be a valid number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cropId As Integer = 0
        If Not String.IsNullOrWhiteSpace(txtCropId.Text) Then
            If Not Integer.TryParse(txtCropId.Text.Trim(), cropId) OrElse cropId <= 0 Then
                MessageBox.Show("Crop ID must be a positive whole number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Try
            Using connection As New MySqlConnection(DatabaseConnectionString())
                connection.Open()

                If cropId = 0 Then
                    Using nextIdCmd As New MySqlCommand("SELECT COALESCE(MAX(crop_id), 0) + 1 FROM crops", connection)
                        cropId = Convert.ToInt32(nextIdCmd.ExecuteScalar())
                    End Using
                End If

                Const sql As String = "INSERT INTO crops (crop_id, crop_name, `type`, seed_cost, growth, sell_cost) " &
                                      "VALUES (@id, @name, @type, @seed, @growth, @sell)"
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@id", cropId)
                    command.Parameters.AddWithValue("@name", txtCropName.Text.Trim())
                    command.Parameters.AddWithValue("@type", txtType.Text.Trim())
                    command.Parameters.AddWithValue("@seed", seedCost)
                    command.Parameters.AddWithValue("@growth", growth)
                    command.Parameters.AddWithValue("@sell", sellCost)
                    command.ExecuteNonQuery()
                End Using
            End Using

            LoadCrops()
            ClearFields()
            MessageBox.Show("Crop added to farm successfully! (ID: " & cropId & ")", "Crop Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("A crop with Crop ID " & cropId & " already exists. Please choose a different ID or use Update.", "Duplicate Crop ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            ShowDatabaseError(ex)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Try
            Dim conditions As New List(Of String)()
            Dim parameters As New List(Of MySqlParameter)()

            If Not String.IsNullOrWhiteSpace(txtCropId.Text) Then
                Dim id As Integer
                If Integer.TryParse(txtCropId.Text.Trim(), id) Then
                    conditions.Add("crop_id = @id")
                    parameters.Add(New MySqlParameter("@id", id))
                End If
            End If

            If Not String.IsNullOrWhiteSpace(txtType.Text) Then
                conditions.Add("`type` LIKE @type")
                parameters.Add(New MySqlParameter("@type", "%" & txtType.Text.Trim() & "%"))
            End If

            If Not String.IsNullOrWhiteSpace(txtCropName.Text) Then
                conditions.Add("crop_name LIKE @name")
                parameters.Add(New MySqlParameter("@name", "%" & txtCropName.Text.Trim() & "%"))
            End If

            If Not String.IsNullOrWhiteSpace(txtSeedCost.Text) Then
                Dim seed As Decimal
                If Decimal.TryParse(txtSeedCost.Text.Trim(), seed) Then
                    conditions.Add("seed_cost = @seed")
                    parameters.Add(New MySqlParameter("@seed", seed))
                End If
            End If

            If Not String.IsNullOrWhiteSpace(txtGrowth.Text) Then
                Dim growthVal As Integer
                If Integer.TryParse(txtGrowth.Text.Trim(), growthVal) Then
                    conditions.Add("growth = @growth")
                    parameters.Add(New MySqlParameter("@growth", growthVal))
                End If
            End If

            If Not String.IsNullOrWhiteSpace(txtSellCost.Text) Then
                Dim sell As Decimal
                If Decimal.TryParse(txtSellCost.Text.Trim(), sell) Then
                    conditions.Add("sell_cost = @sell")
                    parameters.Add(New MySqlParameter("@sell", sell))
                End If
            End If

            If conditions.Count = 0 Then
                LoadCrops()
                If crops IsNot Nothing AndAlso crops.Rows.Count > 0 Then
                    PopulateFieldsFromRow(crops.Rows(0))
                End If
                MessageBox.Show("Displaying all " & crops.Rows.Count & " crop(s) in farm.", "Farm Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim whereClause As String = String.Join(" AND ", conditions)
                LoadCrops(whereClause, parameters)

                If crops IsNot Nothing AndAlso crops.Rows.Count > 0 Then
                    PopulateFieldsFromRow(crops.Rows(0))
                    MessageBox.Show("Found " & crops.Rows.Count & " matching crop(s).", "Crop Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No crops found matching your search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadCrops()
                End If
            End If
        Catch ex As Exception
            ShowDatabaseError(ex)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cropId As Integer = GetSelectedOrEnteredCropId()
        If cropId <= 0 Then
            MessageBox.Show("Please enter a Crop ID or select a crop from the farm list to update.", "No Crop Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtCropName.Text) OrElse String.IsNullOrWhiteSpace(txtType.Text) Then
            MessageBox.Show("Please enter both Crop Name and Type.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim seedCost As Decimal = 0D
        If Not String.IsNullOrWhiteSpace(txtSeedCost.Text) AndAlso Not Decimal.TryParse(txtSeedCost.Text.Trim(), seedCost) Then
            MessageBox.Show("Seed Cost must be a valid number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim growth As Integer = 0
        If Not String.IsNullOrWhiteSpace(txtGrowth.Text) AndAlso Not Integer.TryParse(txtGrowth.Text.Trim(), growth) Then
            MessageBox.Show("Days of Growth must be a whole number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sellCost As Decimal = 0D
        If Not String.IsNullOrWhiteSpace(txtSellCost.Text) AndAlso Not Decimal.TryParse(txtSellCost.Text.Trim(), sellCost) Then
            MessageBox.Show("Sell Cost must be a valid number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim rowsAffected As Integer = 0
            Using connection As New MySqlConnection(DatabaseConnectionString())
                connection.Open()
                Const sql As String = "UPDATE crops SET crop_name = @name, `type` = @type, " &
                                      "seed_cost = @seed, growth = @growth, sell_cost = @sell " &
                                      "WHERE crop_id = @id"
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@id", cropId)
                    command.Parameters.AddWithValue("@name", txtCropName.Text.Trim())
                    command.Parameters.AddWithValue("@type", txtType.Text.Trim())
                    command.Parameters.AddWithValue("@seed", seedCost)
                    command.Parameters.AddWithValue("@growth", growth)
                    command.Parameters.AddWithValue("@sell", sellCost)
                    rowsAffected = command.ExecuteNonQuery()
                End Using
            End Using

            If rowsAffected > 0 Then
                LoadCrops()
                ClearFields()
                MessageBox.Show("Crop #" & cropId & " updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No crop found with Crop ID " & cropId & " to update.", "Crop Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            ShowDatabaseError(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cropId As Integer = GetSelectedOrEnteredCropId()
        If cropId <= 0 Then
            MessageBox.Show("Please enter a Crop ID or select a crop from the farm list to delete.", "No Crop Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete crop #" & cropId & "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim rowsAffected As Integer = 0
            Using connection As New MySqlConnection(DatabaseConnectionString())
                connection.Open()
                Using command As New MySqlCommand("DELETE FROM crops WHERE crop_id = @id", connection)
                    command.Parameters.AddWithValue("@id", cropId)
                    rowsAffected = command.ExecuteNonQuery()
                End Using
            End Using

            If rowsAffected > 0 Then
                LoadCrops()
                ClearFields()
                MessageBox.Show("Crop #" & cropId & " deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No crop found with Crop ID " & cropId & " to delete.", "Crop Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            ShowDatabaseError(ex)
        End Try
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim f As finals = TryCast(Me.MdiParent, finals)
        If f Is Nothing Then
            f = Application.OpenForms.OfType(Of finals)().FirstOrDefault()
        End If

        If f IsNot Nothing Then
            f.Show()
            f.ShowMainScreen()
            f.BringToFront()
        Else
            f = New finals()
            f.Show()
            f.ShowMainScreen()
        End If

        Me.Close()
    End Sub

    Private Function GetSelectedOrEnteredCropId() As Integer
        Dim id As Integer
        If Not String.IsNullOrWhiteSpace(txtCropId.Text) AndAlso Integer.TryParse(txtCropId.Text.Trim(), id) Then
            Return id
        End If

        If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView1.CurrentRow.DataBoundItem IsNot Nothing Then
            Dim rowView = TryCast(DataGridView1.CurrentRow.DataBoundItem, DataRowView)
            If rowView IsNot Nothing AndAlso rowView.Row.Table.Columns.Contains("Crop ID") Then
                Return Convert.ToInt32(rowView.Row("Crop ID"))
            End If
        End If

        Return 0
    End Function

    Private Sub PopulateFieldsFromRow(row As DataRow)
        If row Is Nothing Then Return
        txtCropId.Text = row("Crop ID").ToString()
        txtType.Text = row("Type").ToString()
        txtCropName.Text = row("Crop Name").ToString()
        txtSeedCost.Text = Convert.ToDecimal(row("Seed Cost")).ToString("0.##")
        txtGrowth.Text = row("Days of Growth").ToString()
        txtSellCost.Text = Convert.ToDecimal(row("Sell Cost")).ToString("0.##")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Dim rowView = TryCast(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)
            If rowView IsNot Nothing Then
                PopulateFieldsFromRow(rowView.Row)
            End If
        End If
    End Sub

    Private Sub ClearFields()
        txtCropId.Clear()
        txtType.Clear()
        txtCropName.Clear()
        txtSeedCost.Clear()
        txtGrowth.Clear()
        txtSellCost.Clear()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub ShowDatabaseError(ex As Exception)
        MessageBox.Show("Couldn't connect to XAMPP MySQL database 'farm_db'." & vbCrLf & vbCrLf &
                        "Please ensure MySQL is running in the XAMPP Control Panel." & vbCrLf & vbCrLf &
                        "Error Details:" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
