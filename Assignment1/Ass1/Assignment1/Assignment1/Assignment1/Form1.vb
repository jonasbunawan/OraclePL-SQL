Imports Oracle.DataAccess.Client

Public Class Assignment1
    Public Function GetConnectionString() As String
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=ictoraclesvm1.ict.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SERVICE_NAME=dms)));"
        vConnStr = vConnStr & "User Id= s700513X;"
        vConnStr = vConnStr & "Password= 230891JoNaS.;"

        Return vConnStr
    End Function

    Public Function CreateConnection() As Oracle.DataAccess.Client.OracleConnection
        Dim rvConn As New Oracle.DataAccess.Client.OracleConnection
        rvConn.ConnectionString = GetConnectionString()
        Return rvConn
    End Function

    Private Sub Btn_Add_Cust_Click(sender As Object, e As EventArgs) Handles Btn_Add_Cust.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Add_Customer(InputBox("Customer ID: "), InputBox("Customer Name: "))
    End Sub

    Private Sub Btn_Del_All_Cust_Click(sender As Object, e As EventArgs) Handles Btn_Del_All_Cust.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Delete_All_Customers()
    End Sub

    Private Sub Btn_Add_Prod_Click(sender As Object, e As EventArgs) Handles Btn_Add_Prod.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Add_Product(InputBox("Product ID: "), InputBox("Product Name: "), InputBox("Price: "))
    End Sub

    Private Sub Btn_Del_All_Prod_Click(sender As Object, e As EventArgs) Handles Btn_Del_All_Prod.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Delete_All_Products()
    End Sub

    Private Sub Btn_Get_Cust_Str_Click(sender As Object, e As EventArgs) Handles Btn_Get_Cust_Str.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Get_Customer_String(InputBox("Customer ID: "))
    End Sub

    Private Sub Btn_Upd_Cust_SalesYTD_Click(sender As Object, e As EventArgs) Handles Btn_Upd_Cust_SalesYTD.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Update_Customer_Sales(InputBox("Customer ID: "), InputBox("Amount: "))
    End Sub

    Private Sub Btn_Get_Prod_Str_Click(sender As Object, e As EventArgs) Handles Btn_Get_Prod_Str.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Get_Product_String(InputBox("Product ID: "))
    End Sub

    Private Sub Btn_Upd_Prod_SalesYTD_Click(sender As Object, e As EventArgs) Handles Btn_Upd_Prod_SalesYTD.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Update_Product_Sales(InputBox("Product ID: "), InputBox("Amount: "))
    End Sub

    Private Sub Btn_Upd_Cust_Status_Click(sender As Object, e As EventArgs) Handles Btn_Upd_Cust_Status.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Update_Customer_Status(InputBox("Customer ID: "), InputBox("Status: "))
    End Sub

    Private Sub Btn_Add_Simple_Sale_Click(sender As Object, e As EventArgs) Handles Btn_Add_Simple_Sale.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Add_Simple_Sale(InputBox("Customer ID: "), InputBox("Product ID: "), InputBox("Qty: "))
    End Sub

    Private Sub Btn_Sum_Cust_Sales_Click(sender As Object, e As EventArgs) Handles Btn_Sum_Cust_Sales.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Sum_Customer_Sales()
    End Sub

    Private Sub Btn_Add_Complex_Sale_Click(sender As Object, e As EventArgs) Handles Btn_Add_Complex_Sale.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Add_Complex_Sale(InputBox("Customer ID: "), InputBox("Product ID: "), InputBox("Qty: "), InputBox("Date: "))
    End Sub

    Private Sub Btn_Count_Prod_Sales_Click(sender As Object, e As EventArgs) Handles Btn_Count_Prod_Sales.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Count_Product_Sales(InputBox("Number of days: "))
    End Sub

    Private Sub Btn_Del_Sal_Click(sender As Object, e As EventArgs) Handles Btn_Del_Sal.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Delete_Sale()
    End Sub

    Private Sub Btn_Del_All_Sales_Click(sender As Object, e As EventArgs) Handles Btn_Del_All_Sales.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Delete_All_Sales()
    End Sub

    Private Sub Btn_Del_Cust_Click(sender As Object, e As EventArgs) Handles Btn_Del_Cust.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Delete_Customer(InputBox("Customer ID: "))
    End Sub

    Private Sub Btn_Del_Prod_Click(sender As Object, e As EventArgs) Handles Btn_Del_Prod.Click
        Lbl_Result_Message.Text = ""
        Lbl_Result_Message.Text = Delete_Product(InputBox("Product ID: "))
    End Sub

    Private Sub Btn_Get_All_Cust_Click(sender As Object, e As EventArgs) Handles Btn_Get_All_Cust.Click
        Dim Ds As New DataSet()
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim myCMD As New OracleCommand()
        Dim MyDA As New OracleDataAdapter(myCMD)

        Try
            rvConn = CreateConnection()

            rvConn.Open()

            myCMD.Connection = rvConn
            myCMD.CommandText = "GET_ALLCUST_FROM_DB_PCKG.GET_ALLCUST_FROM_DB"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("pcustcursor", OracleDbType.RefCursor)).Direction = ParameterDirection.Output

            MyDA.Fill(Ds)

            DataGridView1.DataSource = Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub Btn_Get_All_Prod_Click(sender As Object, e As EventArgs) Handles Btn_Get_All_Prod.Click
        Dim Ds As New DataSet()
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim myCMD As New OracleCommand()
        Dim MyDA As New OracleDataAdapter(myCMD)

        Try
            rvConn = CreateConnection()

            rvConn.Open()

            myCMD.Connection = rvConn
            myCMD.CommandText = "GET_ALLPROD_FROM_DB_PCKG.GET_ALLPROD_FROM_DB"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("pprodcursor", OracleDbType.RefCursor)).Direction = ParameterDirection.Output

            MyDA.Fill(Ds)

            DataGridView1.DataSource = Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            rvConn.Close()
        End Try
    End Sub


    Private Sub Btn_Get_All_Sales_Click(sender As Object, e As EventArgs) Handles Btn_Get_All_Sales.Click
        Dim Ds As New DataSet()
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim myCMD As New OracleCommand()
        Dim MyDA As New OracleDataAdapter(myCMD)

        Try
            rvConn = CreateConnection()

            rvConn.Open()

            myCMD.Connection = rvConn
            myCMD.CommandText = "GET_ALLSALES_FROM_DB_PCKG.GET_ALLSALES_FROM_DB"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("psalescursor", OracleDbType.RefCursor)).Direction = ParameterDirection.Output

            MyDA.Fill(Ds)

            DataGridView1.DataSource = Ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub

    Private Function Add_Customer(ByVal vcustid As String, ByVal vcustname As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "ADD_CUSTOMER_TO_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vcustid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustname"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Value = vcustname
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Customer Added OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Delete_All_Customers() As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "DELETE_ALL_CUSTOMERS_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pReturn"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Direction = ParameterDirection.ReturnValue
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return (rvCmd.Parameters.Item("pReturn").Value.ToString & " Rows Deleted")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Add_Product(ByVal vprodid As String, ByVal vprodname As String, ByVal vprice As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "ADD_PRODUCT_TO_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pprodid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vprodid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pprodname"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Value = vprodname
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pprice"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vprice
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Product Added OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Delete_All_Products() As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "DELETE_ALL_PRODUCTS_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pReturn"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Direction = ParameterDirection.ReturnValue
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return (rvCmd.Parameters.Item("pReturn").Value.ToString & " Rows Deleted")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Get_Customer_String(ByVal vcustid As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "GET_CUST_STRING_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pReturn"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Direction = ParameterDirection.ReturnValue
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vcustid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return (rvCmd.Parameters.Item("pReturn").Value.ToString)
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Update_Customer_Sales(ByVal vcustid As String, ByVal vamt As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "UPD_CUST_SALESYTD_IN_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vcustid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustname"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vamt
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Customer Sales Update OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Get_Product_String(ByVal vprodid As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "GET_PROD_STRING_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pReturn"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Direction = ParameterDirection.ReturnValue
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vprodid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return (rvCmd.Parameters.Item("pReturn").Value.ToString)
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Update_Product_Sales(ByVal vprodid As String, ByVal vamt As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "UPD_PROD_SALESYTD_IN_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pprodid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vprodid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pamt"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vamt
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Product Sales Update OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Update_Customer_Status(ByVal vcustid As String, ByVal vstatus As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "UPD_CUST_STATUS_IN_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vcustid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pstatus"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Value = vstatus
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Customer Status Update OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Add_Simple_Sale(ByVal vcustid As String, ByVal vprodid As String, ByVal vqty As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "ADD_SIMPLE_SALE_TO_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vcustid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pprodid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vprodid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pqty"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vqty
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Simple Sale Added OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Sum_Customer_Sales() As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "SUM_CUST_SALESYTD_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pReturn"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Direction = ParameterDirection.ReturnValue
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("All Customer Total: " & rvCmd.Parameters.Item("pReturn").Value.ToString)
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Add_Complex_Sale(ByVal vcustid As String, ByVal vprodid As String, ByVal vqty As String, ByVal vdate As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "ADD_COMPLEX_SALE_TO_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vcustid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pprodid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vprodid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pqty"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vqty
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pdate"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Value = vdate
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Complex Sale Added OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Count_Product_Sales(ByVal vdays As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "COUNT_PRODUCT_SALES_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pReturn"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Direction = ParameterDirection.ReturnValue
            rvCmd.Parameters.Add(rvparamOracle)

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pdays"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vdays
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Total Product Sales: " & rvCmd.Parameters.Item("pReturn").Value.ToString)
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Delete_Sale() As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "DELETE_SALE_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pReturn"
            rvparamOracle.DbType = DbType.String
            rvparamOracle.Size = 1000
            rvparamOracle.Direction = ParameterDirection.ReturnValue
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Sale " & rvCmd.Parameters.Item("pReturn").Value.ToString & " is Deleted")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Delete_All_Sales() As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "DELETE_ALL_SALES_FROM_DB"

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("All Sales Data Deleted")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Delete_Customer(ByVal vcustid As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "DELETE_CUSTOMER_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pcustid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vcustid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Customer " & vcustid & " Deleted OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function

    Private Function Delete_Product(ByVal vprodid As String) As String
        Dim rvConn As Oracle.DataAccess.Client.OracleConnection
        Dim rvCmd As New Oracle.DataAccess.Client.OracleCommand
        Dim rvparamOracle As Oracle.DataAccess.Client.OracleParameter
        Dim rvTran As Oracle.DataAccess.Client.OracleTransaction

        Try
            rvConn = CreateConnection()
            rvConn.Open()
            rvTran = rvConn.BeginTransaction(IsolationLevel.ReadCommitted)

            rvCmd.Connection = rvConn
            rvCmd.CommandType = CommandType.StoredProcedure
            rvCmd.CommandText = "DELETE_PROD_FROM_DB"

            rvparamOracle = New Oracle.DataAccess.Client.OracleParameter
            rvparamOracle.ParameterName = "pprodid"
            rvparamOracle.DbType = DbType.Int32
            rvparamOracle.Value = vprodid
            rvparamOracle.Direction = ParameterDirection.Input
            rvCmd.Parameters.Add(rvparamOracle)

            rvCmd.ExecuteNonQuery()

            rvTran.Commit()

            Return ("Product " & vprodid & " Deleted OK")
        Catch ex As Exception
            rvTran.Rollback()
            Return ex.Message
        Finally
            rvConn.Close()
        End Try
    End Function
End Class
