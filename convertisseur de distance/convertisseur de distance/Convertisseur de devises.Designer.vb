<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Convertisseur_de_devises
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_DEPART = New System.Windows.Forms.TextBox()
        Me.CB_DEPART = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BT_CALC = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TB_ARRIVE = New System.Windows.Forms.TextBox()
        Me.CB_ARRIVE = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Convertisseur de devises du 01/11/16"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CB_DEPART)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(286, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monnaie de départ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TB_DEPART)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 85)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(140, 95)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valeur"
        '
        'TB_DEPART
        '
        Me.TB_DEPART.Location = New System.Drawing.Point(7, 40)
        Me.TB_DEPART.Name = "TB_DEPART"
        Me.TB_DEPART.Size = New System.Drawing.Size(126, 24)
        Me.TB_DEPART.TabIndex = 0
        '
        'CB_DEPART
        '
        Me.CB_DEPART.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DEPART.FormattingEnabled = True
        Me.CB_DEPART.Items.AddRange(New Object() {"Euros", "Dollars", "Livres Sterling"})
        Me.CB_DEPART.Location = New System.Drawing.Point(7, 41)
        Me.CB_DEPART.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_DEPART.Name = "CB_DEPART"
        Me.CB_DEPART.Size = New System.Drawing.Size(140, 23)
        Me.CB_DEPART.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BT_CALC)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.CB_ARRIVE)
        Me.GroupBox3.Location = New System.Drawing.Point(307, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 202)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monnaie convertie"
        '
        'BT_CALC
        '
        Me.BT_CALC.Location = New System.Drawing.Point(179, 156)
        Me.BT_CALC.Name = "BT_CALC"
        Me.BT_CALC.Size = New System.Drawing.Size(75, 23)
        Me.BT_CALC.TabIndex = 2
        Me.BT_CALC.Text = "Calcul"
        Me.BT_CALC.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TB_ARRIVE)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 85)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(140, 95)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valeur"
        '
        'TB_ARRIVE
        '
        Me.TB_ARRIVE.Location = New System.Drawing.Point(6, 40)
        Me.TB_ARRIVE.Name = "TB_ARRIVE"
        Me.TB_ARRIVE.ReadOnly = True
        Me.TB_ARRIVE.Size = New System.Drawing.Size(126, 23)
        Me.TB_ARRIVE.TabIndex = 0
        '
        'CB_ARRIVE
        '
        Me.CB_ARRIVE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ARRIVE.FormattingEnabled = True
        Me.CB_ARRIVE.Items.AddRange(New Object() {"Euros", "Dollars", "Livres Sterling"})
        Me.CB_ARRIVE.Location = New System.Drawing.Point(7, 42)
        Me.CB_ARRIVE.Name = "CB_ARRIVE"
        Me.CB_ARRIVE.Size = New System.Drawing.Size(140, 23)
        Me.CB_ARRIVE.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Version 1.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "© Moi-Même"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Revenir au menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Convertisseur_de_devises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 330)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Convertisseur_de_devises"
        Me.Text = "Convertisseur de devises"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_DEPART As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_DEPART As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_ARRIVE As System.Windows.Forms.TextBox
    Friend WithEvents CB_ARRIVE As System.Windows.Forms.ComboBox
    Friend WithEvents BT_CALC As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
