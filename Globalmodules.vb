Module Globalmodules
    Sub SwitchTableLayout(ByRef TableLayout As TableLayoutPanel)
        Main_Form.MaintableLayout.Controls.Clear()
        Main_Form.MaintableLayout.Controls.Add(TableLayout)
        TableLayout.Show()
    End Sub
End Module
