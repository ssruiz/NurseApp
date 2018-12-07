<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNurse = New System.Windows.Forms.Button()
        Me.btnPatiente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNurse
        '
        Me.btnNurse.Location = New System.Drawing.Point(82, 165)
        Me.btnNurse.Name = "btnNurse"
        Me.btnNurse.Size = New System.Drawing.Size(109, 37)
        Me.btnNurse.TabIndex = 0
        Me.btnNurse.Text = "Nurse"
        Me.btnNurse.UseVisualStyleBackColor = True
        '
        'btnPatiente
        '
        Me.btnPatiente.Location = New System.Drawing.Point(248, 165)
        Me.btnPatiente.Name = "btnPatiente"
        Me.btnPatiente.Size = New System.Drawing.Size(109, 37)
        Me.btnPatiente.TabIndex = 1
        Me.btnPatiente.Text = "Patiente"
        Me.btnPatiente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login as:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 340)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPatiente)
        Me.Controls.Add(Me.btnNurse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNurse As Button
    Friend WithEvents btnPatiente As Button
    Friend WithEvents Label1 As Label
End Class
