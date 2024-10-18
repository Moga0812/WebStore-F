<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StorePage
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
        lstGames = New ListBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        cmbFilter = New ComboBox()
        lblDescription = New Label()
        lblTitle = New Label()
        lblPrice = New Label()
        btnPurchase = New Button()
        picGameImage = New PictureBox()
        btnLibrary = New Button()
        CType(picGameImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstGames
        ' 
        lstGames.FormattingEnabled = True
        lstGames.ItemHeight = 15
        lstGames.Location = New Point(12, 105)
        lstGames.Name = "lstGames"
        lstGames.Size = New Size(194, 529)
        lstGames.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(194, 23)
        txtSearch.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(12, 41)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(194, 32)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' cmbFilter
        ' 
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(85, 76)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(121, 23)
        cmbFilter.TabIndex = 3
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(212, 500)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(67, 15)
        lblDescription.TabIndex = 4
        lblDescription.Text = "Description"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(212, 80)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(29, 15)
        lblTitle.TabIndex = 5
        lblTitle.Text = "Title"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(212, 608)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 6
        lblPrice.Text = "Price"
        ' 
        ' btnPurchase
        ' 
        btnPurchase.Location = New Point(476, 105)
        btnPurchase.Name = "btnPurchase"
        btnPurchase.Size = New Size(130, 60)
        btnPurchase.TabIndex = 7
        btnPurchase.Text = "Purchase"
        btnPurchase.UseVisualStyleBackColor = True
        ' 
        ' picGameImage
        ' 
        picGameImage.Location = New Point(212, 105)
        picGameImage.Name = "picGameImage"
        picGameImage.Size = New Size(258, 382)
        picGameImage.TabIndex = 8
        picGameImage.TabStop = False
        ' 
        ' btnLibrary
        ' 
        btnLibrary.Location = New Point(476, 13)
        btnLibrary.Name = "btnLibrary"
        btnLibrary.Size = New Size(130, 22)
        btnLibrary.TabIndex = 9
        btnLibrary.Text = "Library"
        btnLibrary.UseVisualStyleBackColor = True
        ' 
        ' StorePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(609, 641)
        Controls.Add(btnLibrary)
        Controls.Add(picGameImage)
        Controls.Add(btnPurchase)
        Controls.Add(lblPrice)
        Controls.Add(lblTitle)
        Controls.Add(lblDescription)
        Controls.Add(cmbFilter)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lstGames)
        Name = "StorePage"
        Text = "StorePage"
        CType(picGameImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstGames As ListBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents picGameImage As PictureBox
    Friend WithEvents btnLibrary As Button
End Class
