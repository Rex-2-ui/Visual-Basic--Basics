Public Class Form1

    Private docCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate Format submenus (size, color, font)
        AddFormatMenuItems()
    End Sub

    ' File menu
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        CreateChild(GetType(Form2))
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Create specific child forms (handles style like your sample)
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Dim aForm As New Form2
        aForm.MdiParent = Me
        CreateChildInstance(aForm)
    End Sub


    ' Window layout handlers (Handles style)
    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    ' Populate Format menu programmatically 
    Private Sub AddFormatMenuItems()
        ' Font sizes
        Dim sizes = New Integer() {10, 14, 18}
        For Each s In sizes
            Dim mi = New ToolStripMenuItem($"{s} pt") With {.Tag = s}
            AddHandler mi.Click, Sub(sender, e) SetActiveFontSize(CInt(CType(sender, ToolStripMenuItem).Tag))
            FontSizeToolStripMenuItem.DropDownItems.Add(mi)
        Next

        ' Font colors
        Dim colors = New(String, Color)() {("Black", Color.Black), ("Red", Color.Red), ("Blue", Color.Blue)}
        For Each c In colors
            Dim mi = New ToolStripMenuItem(c.Item1) With {.Tag = c.Item2}
            AddHandler mi.Click, Sub(sender, e) SetActiveFontColor(CType(CType(sender, ToolStripMenuItem).Tag, Color))
            FontColorToolStripMenuItem.DropDownItems.Add(mi)
        Next

        ' Font families
        Dim families = New String() {"Microsoft Sans Serif", "Consolas", "Comic Sans MS"}
        For Each f In families
            Dim mi = New ToolStripMenuItem(f) With {.Tag = f}
            AddHandler mi.Click, Sub(sender, e) SetActiveFontFamily(CType(sender, ToolStripMenuItem).Tag.ToString())
            FontToolStripMenuItem.DropDownItems.Add(mi)
        Next
    End Sub

    ' Display the list of open MDI children (Windows menu)
    Private Sub DisplayToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.DropDownOpening
        ' Keep first two layout items (Cascade, Tile). Remove previously added window list items.
        While DisplayToolStripMenuItem.DropDownItems.Count > 2
            DisplayToolStripMenuItem.DropDownItems.RemoveAt(2)
        End While

        If MdiChildren.Length = 0 Then
            Dim noneItem = New ToolStripMenuItem("(No windows)") With {.Enabled = False}
            DisplayToolStripMenuItem.DropDownItems.Add(noneItem)
            Return
        End If

        DisplayToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator())

        For Each child As Form In MdiChildren
            Dim mi = New ToolStripMenuItem(child.Text) With {.Tag = child}
            mi.Checked = (child Is ActiveMdiChild)
            AddHandler mi.Click, Sub(s, ea)
                                     Dim clicked = CType(CType(s, ToolStripMenuItem).Tag, Form)
                                     If clicked IsNot Nothing Then clicked.Activate()
                                 End Sub
            DisplayToolStripMenuItem.DropDownItems.Add(mi)
        Next
    End Sub

    ' Helpers

    Private Sub CreateChild(childType As Type)
        Dim frm As Form = CType(Activator.CreateInstance(childType), Form)
        frm.MdiParent = Me
        CreateChildInstance(frm)
    End Sub

    Private Sub CreateChildInstance(frm As Form)
        docCount += 1
        frm.Text = $"Document {docCount}"
        ' Dock any RichTextBox in the child to fill client area
        For Each ctl As Control In frm.Controls
            If TypeOf ctl Is RichTextBox Then
                ctl.Dock = DockStyle.Fill
            End If
        Next
        frm.Show()
    End Sub

    Private Function GetActiveRichTextBox() As RichTextBox
        If ActiveMdiChild Is Nothing Then Return Nothing
        For Each ctl As Control In ActiveMdiChild.Controls
            If TypeOf ctl Is RichTextBox Then
                Return CType(ctl, RichTextBox)
            End If
        Next
        Return Nothing
    End Function

    Private Sub SetActiveFontSize(size As Integer)
        Dim rtb = GetActiveRichTextBox()
        If rtb Is Nothing Then Return

        Dim hadSelection = rtb.SelectionLength > 0
        If Not hadSelection Then rtb.SelectAll()

        Dim currentFont As Font = rtb.SelectionFont
        If currentFont Is Nothing Then currentFont = rtb.Font
        Dim newFont As New Font(currentFont.FontFamily, size, currentFont.Style)
        rtb.SelectionFont = newFont

        If Not hadSelection Then rtb.DeselectAll()
    End Sub

    Private Sub SetActiveFontFamily(fontName As String)
        Dim rtb = GetActiveRichTextBox()
        If rtb Is Nothing Then Return

        Dim hadSelection = rtb.SelectionLength > 0
        If Not hadSelection Then rtb.SelectAll()

        Dim currentFont As Font = rtb.SelectionFont
        If currentFont Is Nothing Then currentFont = rtb.Font
        Dim newFont As New Font(fontName, currentFont.Size, currentFont.Style)
        rtb.SelectionFont = newFont

        If Not hadSelection Then rtb.DeselectAll()
    End Sub

    Private Sub SetActiveFontColor(col As Color)
        Dim rtb = GetActiveRichTextBox()
        If rtb Is Nothing Then Return

        Dim hadSelection = rtb.SelectionLength > 0
        If Not hadSelection Then rtb.SelectAll()

        rtb.SelectionColor = col

        If Not hadSelection Then rtb.DeselectAll()
    End Sub

End Class
