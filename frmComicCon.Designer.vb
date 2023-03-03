<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGrp = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radCon = New System.Windows.Forms.RadioButton()
        Me.radConAuto = New System.Windows.Forms.RadioButton()
        Me.radConSpr = New System.Windows.Forms.RadioButton()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblHeading.Location = New System.Drawing.Point(13, 210)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(552, 51)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(579, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(129, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Group Size:"
        '
        'txtGrp
        '
        Me.txtGrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrp.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtGrp.Location = New System.Drawing.Point(304, 275)
        Me.txtGrp.Multiline = True
        Me.txtGrp.Name = "txtGrp"
        Me.txtGrp.Size = New System.Drawing.Size(66, 39)
        Me.txtGrp.TabIndex = 3
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.SkyBlue
        Me.grpBadgeType.Controls.Add(Me.radCon)
        Me.grpBadgeType.Controls.Add(Me.radConAuto)
        Me.grpBadgeType.Controls.Add(Me.radConSpr)
        Me.grpBadgeType.Font = New System.Drawing.Font("Broadway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.OrangeRed
        Me.grpBadgeType.Location = New System.Drawing.Point(103, 341)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(372, 106)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radCon
        '
        Me.radCon.AutoSize = True
        Me.radCon.Font = New System.Drawing.Font("Broadway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCon.Location = New System.Drawing.Point(7, 76)
        Me.radCon.Name = "radCon"
        Me.radCon.Size = New System.Drawing.Size(135, 24)
        Me.radCon.TabIndex = 2
        Me.radCon.Text = "Convention"
        Me.radCon.UseVisualStyleBackColor = True
        '
        'radConAuto
        '
        Me.radConAuto.AutoSize = True
        Me.radConAuto.Font = New System.Drawing.Font("Broadway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConAuto.Location = New System.Drawing.Point(7, 49)
        Me.radConAuto.Name = "radConAuto"
        Me.radConAuto.Size = New System.Drawing.Size(261, 24)
        Me.radConAuto.TabIndex = 1
        Me.radConAuto.Text = "Convention + Autographs"
        Me.radConAuto.UseVisualStyleBackColor = True
        '
        'radConSpr
        '
        Me.radConSpr.AutoSize = True
        Me.radConSpr.Checked = True
        Me.radConSpr.Font = New System.Drawing.Font("Broadway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConSpr.Location = New System.Drawing.Point(7, 22)
        Me.radConSpr.Name = "radConSpr"
        Me.radConSpr.Size = New System.Drawing.Size(357, 24)
        Me.radConSpr.TabIndex = 0
        Me.radConSpr.TabStop = True
        Me.radConSpr.Text = "Convention + Superhero Experience"
        Me.radConSpr.UseVisualStyleBackColor = True
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblReg.Location = New System.Drawing.Point(132, 465)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(200, 22)
        Me.lblReg.TabIndex = 5
        Me.lblReg.Text = "Registration Cost:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCost.Location = New System.Drawing.Point(357, 465)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(109, 22)
        Me.lblCost.TabIndex = 6
        Me.lblCost.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(131, 509)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(133, 36)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(291, 509)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 36)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 579)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtGrp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Comic Convention Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGrp As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radCon As RadioButton
    Friend WithEvents radConAuto As RadioButton
    Friend WithEvents radConSpr As RadioButton
    Friend WithEvents lblReg As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
