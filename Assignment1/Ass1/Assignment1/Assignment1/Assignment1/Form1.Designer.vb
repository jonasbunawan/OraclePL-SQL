<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assignment1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Add_Cust = New System.Windows.Forms.Button()
        Me.Btn_Del_All_Cust = New System.Windows.Forms.Button()
        Me.Btn_Add_Prod = New System.Windows.Forms.Button()
        Me.Btn_Del_All_Prod = New System.Windows.Forms.Button()
        Me.Btn_Get_Cust_Str = New System.Windows.Forms.Button()
        Me.Btn_Upd_Cust_SalesYTD = New System.Windows.Forms.Button()
        Me.Btn_Get_Prod_Str = New System.Windows.Forms.Button()
        Me.Btn_Upd_Prod_SalesYTD = New System.Windows.Forms.Button()
        Me.Btn_Upd_Cust_Status = New System.Windows.Forms.Button()
        Me.Btn_Add_Simple_Sale = New System.Windows.Forms.Button()
        Me.Btn_Sum_Cust_Sales = New System.Windows.Forms.Button()
        Me.Lbl_Functions = New System.Windows.Forms.Label()
        Me.Lbl_Result = New System.Windows.Forms.Label()
        Me.Lbl_Result_Message = New System.Windows.Forms.Label()
        Me.Btn_Get_All_Prod = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Get_All_Cust = New System.Windows.Forms.Button()
        Me.Btn_Add_Complex_Sale = New System.Windows.Forms.Button()
        Me.Btn_Get_All_Sales = New System.Windows.Forms.Button()
        Me.Btn_Count_Prod_Sales = New System.Windows.Forms.Button()
        Me.Btn_Del_Sal = New System.Windows.Forms.Button()
        Me.Btn_Del_All_Sales = New System.Windows.Forms.Button()
        Me.Btn_Del_Cust = New System.Windows.Forms.Button()
        Me.Btn_Del_Prod = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Add_Cust
        '
        Me.Btn_Add_Cust.Location = New System.Drawing.Point(12, 25)
        Me.Btn_Add_Cust.Name = "Btn_Add_Cust"
        Me.Btn_Add_Cust.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Add_Cust.TabIndex = 0
        Me.Btn_Add_Cust.Text = "Add Customer"
        Me.Btn_Add_Cust.UseVisualStyleBackColor = True
        '
        'Btn_Del_All_Cust
        '
        Me.Btn_Del_All_Cust.Location = New System.Drawing.Point(12, 54)
        Me.Btn_Del_All_Cust.Name = "Btn_Del_All_Cust"
        Me.Btn_Del_All_Cust.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Del_All_Cust.TabIndex = 1
        Me.Btn_Del_All_Cust.Text = "Delete All Customers"
        Me.Btn_Del_All_Cust.UseVisualStyleBackColor = True
        '
        'Btn_Add_Prod
        '
        Me.Btn_Add_Prod.Location = New System.Drawing.Point(12, 83)
        Me.Btn_Add_Prod.Name = "Btn_Add_Prod"
        Me.Btn_Add_Prod.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Add_Prod.TabIndex = 2
        Me.Btn_Add_Prod.Text = "Add Product"
        Me.Btn_Add_Prod.UseVisualStyleBackColor = True
        '
        'Btn_Del_All_Prod
        '
        Me.Btn_Del_All_Prod.Location = New System.Drawing.Point(12, 112)
        Me.Btn_Del_All_Prod.Name = "Btn_Del_All_Prod"
        Me.Btn_Del_All_Prod.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Del_All_Prod.TabIndex = 3
        Me.Btn_Del_All_Prod.Text = "Delete All Products"
        Me.Btn_Del_All_Prod.UseVisualStyleBackColor = True
        '
        'Btn_Get_Cust_Str
        '
        Me.Btn_Get_Cust_Str.Location = New System.Drawing.Point(12, 141)
        Me.Btn_Get_Cust_Str.Name = "Btn_Get_Cust_Str"
        Me.Btn_Get_Cust_Str.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Get_Cust_Str.TabIndex = 4
        Me.Btn_Get_Cust_Str.Text = "Get Customer String"
        Me.Btn_Get_Cust_Str.UseVisualStyleBackColor = True
        '
        'Btn_Upd_Cust_SalesYTD
        '
        Me.Btn_Upd_Cust_SalesYTD.Location = New System.Drawing.Point(12, 170)
        Me.Btn_Upd_Cust_SalesYTD.Name = "Btn_Upd_Cust_SalesYTD"
        Me.Btn_Upd_Cust_SalesYTD.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Upd_Cust_SalesYTD.TabIndex = 5
        Me.Btn_Upd_Cust_SalesYTD.Text = "Update Customer Sales"
        Me.Btn_Upd_Cust_SalesYTD.UseVisualStyleBackColor = True
        '
        'Btn_Get_Prod_Str
        '
        Me.Btn_Get_Prod_Str.Location = New System.Drawing.Point(12, 199)
        Me.Btn_Get_Prod_Str.Name = "Btn_Get_Prod_Str"
        Me.Btn_Get_Prod_Str.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Get_Prod_Str.TabIndex = 6
        Me.Btn_Get_Prod_Str.Text = "Get Product String"
        Me.Btn_Get_Prod_Str.UseVisualStyleBackColor = True
        '
        'Btn_Upd_Prod_SalesYTD
        '
        Me.Btn_Upd_Prod_SalesYTD.Location = New System.Drawing.Point(12, 228)
        Me.Btn_Upd_Prod_SalesYTD.Name = "Btn_Upd_Prod_SalesYTD"
        Me.Btn_Upd_Prod_SalesYTD.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Upd_Prod_SalesYTD.TabIndex = 7
        Me.Btn_Upd_Prod_SalesYTD.Text = "Update Product Sales"
        Me.Btn_Upd_Prod_SalesYTD.UseVisualStyleBackColor = True
        '
        'Btn_Upd_Cust_Status
        '
        Me.Btn_Upd_Cust_Status.Location = New System.Drawing.Point(12, 257)
        Me.Btn_Upd_Cust_Status.Name = "Btn_Upd_Cust_Status"
        Me.Btn_Upd_Cust_Status.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Upd_Cust_Status.TabIndex = 8
        Me.Btn_Upd_Cust_Status.Text = "Update Customer Status"
        Me.Btn_Upd_Cust_Status.UseVisualStyleBackColor = True
        '
        'Btn_Add_Simple_Sale
        '
        Me.Btn_Add_Simple_Sale.Location = New System.Drawing.Point(12, 286)
        Me.Btn_Add_Simple_Sale.Name = "Btn_Add_Simple_Sale"
        Me.Btn_Add_Simple_Sale.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Add_Simple_Sale.TabIndex = 9
        Me.Btn_Add_Simple_Sale.Text = "Add Simple Sale"
        Me.Btn_Add_Simple_Sale.UseVisualStyleBackColor = True
        '
        'Btn_Sum_Cust_Sales
        '
        Me.Btn_Sum_Cust_Sales.Location = New System.Drawing.Point(12, 315)
        Me.Btn_Sum_Cust_Sales.Name = "Btn_Sum_Cust_Sales"
        Me.Btn_Sum_Cust_Sales.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Sum_Cust_Sales.TabIndex = 10
        Me.Btn_Sum_Cust_Sales.Text = "Sum Customer Sales"
        Me.Btn_Sum_Cust_Sales.UseVisualStyleBackColor = True
        '
        'Lbl_Functions
        '
        Me.Lbl_Functions.AutoSize = True
        Me.Lbl_Functions.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Functions.Name = "Lbl_Functions"
        Me.Lbl_Functions.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_Functions.TabIndex = 11
        Me.Lbl_Functions.Text = "Functions:"
        '
        'Lbl_Result
        '
        Me.Lbl_Result.AutoSize = True
        Me.Lbl_Result.Location = New System.Drawing.Point(162, 9)
        Me.Lbl_Result.Name = "Lbl_Result"
        Me.Lbl_Result.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Result.TabIndex = 12
        Me.Lbl_Result.Text = "Result:"
        '
        'Lbl_Result_Message
        '
        Me.Lbl_Result_Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Result_Message.Location = New System.Drawing.Point(165, 25)
        Me.Lbl_Result_Message.Name = "Lbl_Result_Message"
        Me.Lbl_Result_Message.Size = New System.Drawing.Size(235, 399)
        Me.Lbl_Result_Message.TabIndex = 13
        '
        'Btn_Get_All_Prod
        '
        Me.Btn_Get_All_Prod.Location = New System.Drawing.Point(657, 228)
        Me.Btn_Get_All_Prod.Name = "Btn_Get_All_Prod"
        Me.Btn_Get_All_Prod.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Get_All_Prod.TabIndex = 14
        Me.Btn_Get_All_Prod.Text = "Get All Products"
        Me.Btn_Get_All_Prod.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(406, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(489, 168)
        Me.DataGridView1.TabIndex = 15
        '
        'Btn_Get_All_Cust
        '
        Me.Btn_Get_All_Cust.Location = New System.Drawing.Point(657, 199)
        Me.Btn_Get_All_Cust.Name = "Btn_Get_All_Cust"
        Me.Btn_Get_All_Cust.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Get_All_Cust.TabIndex = 16
        Me.Btn_Get_All_Cust.Text = "Get All Customers"
        Me.Btn_Get_All_Cust.UseVisualStyleBackColor = True
        '
        'Btn_Add_Complex_Sale
        '
        Me.Btn_Add_Complex_Sale.Location = New System.Drawing.Point(12, 344)
        Me.Btn_Add_Complex_Sale.Name = "Btn_Add_Complex_Sale"
        Me.Btn_Add_Complex_Sale.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Add_Complex_Sale.TabIndex = 17
        Me.Btn_Add_Complex_Sale.Text = "Add Complex Sale"
        Me.Btn_Add_Complex_Sale.UseVisualStyleBackColor = True
        '
        'Btn_Get_All_Sales
        '
        Me.Btn_Get_All_Sales.Location = New System.Drawing.Point(657, 257)
        Me.Btn_Get_All_Sales.Name = "Btn_Get_All_Sales"
        Me.Btn_Get_All_Sales.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Get_All_Sales.TabIndex = 18
        Me.Btn_Get_All_Sales.Text = "Get All Sales"
        Me.Btn_Get_All_Sales.UseVisualStyleBackColor = True
        '
        'Btn_Count_Prod_Sales
        '
        Me.Btn_Count_Prod_Sales.Location = New System.Drawing.Point(12, 373)
        Me.Btn_Count_Prod_Sales.Name = "Btn_Count_Prod_Sales"
        Me.Btn_Count_Prod_Sales.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Count_Prod_Sales.TabIndex = 19
        Me.Btn_Count_Prod_Sales.Text = "Count Product Sales"
        Me.Btn_Count_Prod_Sales.UseVisualStyleBackColor = True
        '
        'Btn_Del_Sal
        '
        Me.Btn_Del_Sal.Location = New System.Drawing.Point(504, 257)
        Me.Btn_Del_Sal.Name = "Btn_Del_Sal"
        Me.Btn_Del_Sal.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Del_Sal.TabIndex = 20
        Me.Btn_Del_Sal.Text = "Delete Sale"
        Me.Btn_Del_Sal.UseVisualStyleBackColor = True
        '
        'Btn_Del_All_Sales
        '
        Me.Btn_Del_All_Sales.Location = New System.Drawing.Point(12, 402)
        Me.Btn_Del_All_Sales.Name = "Btn_Del_All_Sales"
        Me.Btn_Del_All_Sales.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Del_All_Sales.TabIndex = 21
        Me.Btn_Del_All_Sales.Text = "Delete All Sales"
        Me.Btn_Del_All_Sales.UseVisualStyleBackColor = True
        '
        'Btn_Del_Cust
        '
        Me.Btn_Del_Cust.Location = New System.Drawing.Point(504, 199)
        Me.Btn_Del_Cust.Name = "Btn_Del_Cust"
        Me.Btn_Del_Cust.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Del_Cust.TabIndex = 22
        Me.Btn_Del_Cust.Text = "Delete Customer"
        Me.Btn_Del_Cust.UseVisualStyleBackColor = True
        '
        'Btn_Del_Prod
        '
        Me.Btn_Del_Prod.Location = New System.Drawing.Point(504, 228)
        Me.Btn_Del_Prod.Name = "Btn_Del_Prod"
        Me.Btn_Del_Prod.Size = New System.Drawing.Size(147, 23)
        Me.Btn_Del_Prod.TabIndex = 23
        Me.Btn_Del_Prod.Text = "Delete Product"
        Me.Btn_Del_Prod.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(582, 327)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(143, 56)
        Me.Btn_Exit.TabIndex = 24
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Assignment1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 433)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_Del_Prod)
        Me.Controls.Add(Me.Btn_Del_Cust)
        Me.Controls.Add(Me.Btn_Del_All_Sales)
        Me.Controls.Add(Me.Btn_Del_Sal)
        Me.Controls.Add(Me.Btn_Count_Prod_Sales)
        Me.Controls.Add(Me.Btn_Get_All_Sales)
        Me.Controls.Add(Me.Btn_Add_Complex_Sale)
        Me.Controls.Add(Me.Btn_Get_All_Cust)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Get_All_Prod)
        Me.Controls.Add(Me.Lbl_Result_Message)
        Me.Controls.Add(Me.Lbl_Result)
        Me.Controls.Add(Me.Lbl_Functions)
        Me.Controls.Add(Me.Btn_Sum_Cust_Sales)
        Me.Controls.Add(Me.Btn_Add_Simple_Sale)
        Me.Controls.Add(Me.Btn_Upd_Cust_Status)
        Me.Controls.Add(Me.Btn_Upd_Prod_SalesYTD)
        Me.Controls.Add(Me.Btn_Get_Prod_Str)
        Me.Controls.Add(Me.Btn_Upd_Cust_SalesYTD)
        Me.Controls.Add(Me.Btn_Get_Cust_Str)
        Me.Controls.Add(Me.Btn_Del_All_Prod)
        Me.Controls.Add(Me.Btn_Add_Prod)
        Me.Controls.Add(Me.Btn_Del_All_Cust)
        Me.Controls.Add(Me.Btn_Add_Cust)
        Me.Name = "Assignment1"
        Me.Text = "Assignment 1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Add_Cust As System.Windows.Forms.Button
    Friend WithEvents Btn_Del_All_Cust As System.Windows.Forms.Button
    Friend WithEvents Btn_Add_Prod As System.Windows.Forms.Button
    Friend WithEvents Btn_Del_All_Prod As System.Windows.Forms.Button
    Friend WithEvents Btn_Get_Cust_Str As System.Windows.Forms.Button
    Friend WithEvents Btn_Upd_Cust_SalesYTD As System.Windows.Forms.Button
    Friend WithEvents Btn_Get_Prod_Str As System.Windows.Forms.Button
    Friend WithEvents Btn_Upd_Prod_SalesYTD As System.Windows.Forms.Button
    Friend WithEvents Btn_Upd_Cust_Status As System.Windows.Forms.Button
    Friend WithEvents Btn_Add_Simple_Sale As System.Windows.Forms.Button
    Friend WithEvents Btn_Sum_Cust_Sales As System.Windows.Forms.Button
    Friend WithEvents Lbl_Functions As System.Windows.Forms.Label
    Friend WithEvents Lbl_Result As System.Windows.Forms.Label
    Friend WithEvents Lbl_Result_Message As System.Windows.Forms.Label
    Friend WithEvents Btn_Get_All_Prod As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Get_All_Cust As System.Windows.Forms.Button
    Friend WithEvents Btn_Add_Complex_Sale As System.Windows.Forms.Button
    Friend WithEvents Btn_Get_All_Sales As System.Windows.Forms.Button
    Friend WithEvents Btn_Count_Prod_Sales As System.Windows.Forms.Button
    Friend WithEvents Btn_Del_Sal As System.Windows.Forms.Button
    Friend WithEvents Btn_Del_All_Sales As System.Windows.Forms.Button
    Friend WithEvents Btn_Del_Cust As System.Windows.Forms.Button
    Friend WithEvents Btn_Del_Prod As System.Windows.Forms.Button
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button

End Class
