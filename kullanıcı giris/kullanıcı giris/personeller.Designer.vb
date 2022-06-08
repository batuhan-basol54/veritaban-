<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personeller
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtsilid = New System.Windows.Forms.TextBox()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.Textsifre = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Textkullan = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(9, 284)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(779, 138)
        Me.ListView1.TabIndex = 11
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ad Soyad"
        Me.ColumnHeader2.Width = 139
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tel"
        Me.ColumnHeader3.Width = 129
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Kullanıcı"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sifre"
        Me.ColumnHeader5.Width = 80
        '
        'txtsilid
        '
        Me.txtsilid.Location = New System.Drawing.Point(666, 248)
        Me.txtsilid.Name = "txtsilid"
        Me.txtsilid.Size = New System.Drawing.Size(100, 20)
        Me.txtsilid.TabIndex = 13
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(135, 63)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(100, 20)
        Me.txtpid.TabIndex = 6
        '
        'Textsifre
        '
        Me.Textsifre.Location = New System.Drawing.Point(605, 63)
        Me.Textsifre.Name = "Textsifre"
        Me.Textsifre.Size = New System.Drawing.Size(100, 20)
        Me.Textsifre.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(371, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Textkullan
        '
        Me.Textkullan.Location = New System.Drawing.Point(487, 63)
        Me.Textkullan.Name = "Textkullan"
        Me.Textkullan.Size = New System.Drawing.Size(100, 20)
        Me.Textkullan.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(254, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(295, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Güncelle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Kayıt Ekle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.TabStop = False
        Me.Button1.Text = "BAĞLI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'personeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtsilid)
        Me.Controls.Add(Me.txtpid)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Textsifre)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Textkullan)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "personeller"
        Me.Text = "personeller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents txtsilid As TextBox
    Friend WithEvents txtpid As TextBox
    Friend WithEvents Textsifre As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Textkullan As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
