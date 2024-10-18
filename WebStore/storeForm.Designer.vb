<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstGames = New ListBox()
        lblDescription = New Label()
        lblPrice = New Label()
        lblTitle = New Label()
        btnPurchase = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        cmbFilter = New ComboBox()
        picImagePath = New PictureBox()
        CType(picImagePath, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstGames
        ' 
        lstGames.FormattingEnabled = True
        lstGames.ItemHeight = 15
        lstGames.Location = New Point(12, 102)
        lstGames.Name = "lstGames"
        lstGames.Size = New Size(195, 529)
        lstGames.TabIndex = 0
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(227, 457)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(70, 15)
        lblDescription.TabIndex = 1
        lblDescription.Text = "Description:"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(227, 567)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(36, 15)
        lblPrice.TabIndex = 2
        lblPrice.Text = "Price:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(227, 73)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(29, 15)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Title"
        ' 
        ' btnPurchase
        ' 
        btnPurchase.Location = New Point(550, 251)
        btnPurchase.Name = "btnPurchase"
        btnPurchase.Size = New Size(75, 23)
        btnPurchase.TabIndex = 4
        btnPurchase.Text = "Purchase"
        btnPurchase.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(12, 44)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(195, 23)
        txtSearch.TabIndex = 6
        ' 
        ' cmbFilter
        ' 
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(86, 73)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(121, 23)
        cmbFilter.TabIndex = 7
        ' 
        ' picImagePath
        ' 
        picImagePath.Location = New Point(227, 102)
        picImagePath.Name = "picImagePath"
        picImagePath.Size = New Size(247, 332)
        picImagePath.TabIndex = 8
        picImagePath.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(697, 643)
        Controls.Add(picImagePath)
        Controls.Add(cmbFilter)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(btnPurchase)
        Controls.Add(lblTitle)
        Controls.Add(lblPrice)
        Controls.Add(lblDescription)
        Controls.Add(lstGames)
        Name = "Form1"
        Text = "Form1"
        CType(picImagePath, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstGames As ListBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents picImagePath As PictureBox

End Class
