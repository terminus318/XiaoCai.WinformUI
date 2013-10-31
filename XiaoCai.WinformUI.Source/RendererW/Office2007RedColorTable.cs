using System.Drawing;
using System.Collections.Generic;

namespace XiaoCai.WinformUI.Panels
{
    /// <summary>
    /// Provides colors used for Microsoft Office 2007 blue display elements.
    /// </summary>
    public class Office2007RedColorTable : XiaoCai.WinformUI.Panels.OfficeColorTable
	{
		#region FieldsPrivate
        private PanelColors m_panelColorTable;
        #endregion

		#region Properties
        /// <summary>
        /// Gets the associated ColorTable for the XPanderControls
        /// </summary>
        public override PanelColors PanelColorTable
        {
            get
            {
                if (this.m_panelColorTable == null)
                {
                    this.m_panelColorTable = new PanelColorsOffice2007Red();
                }
                return this.m_panelColorTable;
            }
        }
		#endregion

        #region MethodsProtected
        /// <summary>
        /// Unitializes a color dictionary with defined colors
        /// </summary>
        /// <param name="rgbTable">Dictionary with defined colors</param>
        protected override void InitColors(Dictionary<ProfessionalColorTable.KnownColors, Color> rgbTable)
        {
            rgbTable[KnownColors.ButtonPressedBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.ButtonPressedGradientBegin] = Color.FromArgb(248, 181, 106);
            rgbTable[KnownColors.ButtonPressedGradientEnd] = Color.FromArgb(255, 208, 134);
            rgbTable[KnownColors.ButtonPressedGradientMiddle] = Color.FromArgb(251, 140, 60);

            rgbTable[KnownColors.ButtonSelectedBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.ButtonSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColors.ButtonSelectedGradientEnd] = Color.FromArgb(255, 219, 117);
            rgbTable[KnownColors.ButtonSelectedGradientMiddle] = Color.FromArgb(255, 231, 162);
			rgbTable[KnownColors.ButtonSelectedHighlightBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.CheckBackground] = Color.FromArgb(255, 227, 149);
			rgbTable[KnownColors.CheckSelectedBackground] = Color.FromArgb(254, 128, 62);
            rgbTable[KnownColors.GripDark] = Color.Maroon;
            rgbTable[KnownColors.GripLight] = Color.HotPink;
            rgbTable[KnownColors.ImageMarginGradientBegin] = Color.FromArgb(233, 238, 238);
            rgbTable[KnownColors.MenuBorder] = Color.FromArgb(134, 134, 134);
            rgbTable[KnownColors.MenuItemBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.MenuItemPressedGradientBegin] = Color.LightPink;
            rgbTable[KnownColors.MenuItemPressedGradientEnd] = Color.HotPink;
            rgbTable[KnownColors.MenuItemPressedGradientMiddle] = Color.LightPink;
			rgbTable[KnownColors.MenuItemSelected] = Color.FromArgb(255, 238, 194);
			rgbTable[KnownColors.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColors.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
			rgbTable[KnownColors.MenuItemText] = Color.Black;

            rgbTable[KnownColors.MenuStripGradientBegin] = Color.Pink;
            rgbTable[KnownColors.MenuStripGradientEnd] = Color.Pink;

            rgbTable[KnownColors.OverflowButtonGradientBegin] = Color.LightPink;
            rgbTable[KnownColors.OverflowButtonGradientEnd] = Color.HotPink;
            rgbTable[KnownColors.OverflowButtonGradientMiddle] = Color.LightPink;

            //rgbTable[KnownColors.OverflowButtonGradientBegin] = Color.FromArgb(167, 204, 251);
            //rgbTable[KnownColors.OverflowButtonGradientEnd] = Color.FromArgb(101, 147, 207);
            //rgbTable[KnownColors.OverflowButtonGradientMiddle] = Color.FromArgb(167, 204, 251);

            rgbTable[KnownColors.RaftingContainerGradientBegin] = Color.HotPink;
            rgbTable[KnownColors.RaftingContainerGradientEnd] = Color.HotPink;

            rgbTable[KnownColors.SeparatorDark] = Color.LightCoral;
            rgbTable[KnownColors.SeparatorLight] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.StatusStripGradientBegin] = Color.Pink;
            rgbTable[KnownColors.StatusStripGradientEnd] = Color.LightCoral;
			rgbTable[KnownColors.StatusStripText] = Color.Black;


            rgbTable[KnownColors.ToolStripBorder] = Color.LightCoral;
            rgbTable[KnownColors.ToolStripContentPanelGradientBegin] = Color.LightCoral;
            rgbTable[KnownColors.ToolStripContentPanelGradientEnd] = Color.IndianRed;
            rgbTable[KnownColors.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColors.ToolStripGradientBegin] = Color.LightPink;
            rgbTable[KnownColors.ToolStripGradientEnd] = Color.LightCoral;

            //rgbTable[KnownColors.ToolStripGradientMiddle] = Color.FromArgb(222, 236, 255);
            //rgbTable[KnownColors.ToolStripPanelGradientBegin] = Color.FromArgb(191, 219, 255);
            //rgbTable[KnownColors.ToolStripPanelGradientEnd] = Color.FromArgb(191, 219, 255);

            rgbTable[KnownColors.ToolStripGradientMiddle] = Color.LightPink;

            rgbTable[KnownColors.ToolStripPanelGradientBegin] = Color.Pink;
            rgbTable[KnownColors.ToolStripPanelGradientEnd] = Color.Pink;

            rgbTable[KnownColors.ToolStripText] = Color.FromArgb(0, 0, 0);
            #region ��չ�ؼ���ʽ
            rgbTable[KnownColors.TextBoxBorderColor] = Color.Maroon;
            rgbTable[KnownColors.ButtonTextColor] = Color.Black;
            rgbTable[KnownColors.ButtonBorderColor] = Color.Maroon;

            //Button Nomal BackColor
            rgbTable[KnownColors.ButtonNormalBorder] = Color.Maroon;
            rgbTable[KnownColors.ButtonNormalGradientBegin] = Color.LightCoral;
            rgbTable[KnownColors.ButtonNormalGradientEnd] = Color.LightCoral;
            rgbTable[KnownColors.ButtonNormalGradientMiddle] = Color.Maroon;

            //CheckBox
            rgbTable[KnownColors.CheckBoxBaseColor] = Color.Maroon;
            rgbTable[KnownColors.CheckBoxBorderColor] = Color.Maroon;
            rgbTable[KnownColors.CheckBoxTextColor] = Color.Black;
            rgbTable[KnownColors.CheckBoxInnerBorderColor] = Color.FromArgb(255, 255, 218, 114);
            //ComboBox
            rgbTable[KnownColors.ComboBoxBaseColor] = Color.HotPink;
            rgbTable[KnownColors.ComboBoxBorderColor] = Color.Maroon;
            rgbTable[KnownColors.ComboBoxArrowColor] = Color.Maroon;
            rgbTable[KnownColors.ComboBoxBorderHoverColor] = Color.FromArgb(255, 255, 200, 138);
            rgbTable[KnownColors.ComboBoxHoverColor] = Color.FromArgb(255, 214, 108);
            rgbTable[KnownColors.ComboBoxPressColor] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.ComboBoxBorderPressColor] = Color.FromArgb(255, 255, 200, 138);
            //GridView
            rgbTable[KnownColors.GridViewColumnHeaderUpColor] = Color.Firebrick;
            rgbTable[KnownColors.GridViewColumnHeaderDownColor] = Color.Maroon;
            rgbTable[KnownColors.GridViewBackColor] = Color.FromArgb(234, 247, 254);
            rgbTable[KnownColors.GridViewGridColor] = Color.Firebrick;
            rgbTable[KnownColors.GridViewTextColor] = Color.Black;
            //Form
            rgbTable[KnownColors.FormBackColor] = Color.Pink;
            rgbTable[KnownColors.FormHeaderUpColor] = Color.Firebrick;
            rgbTable[KnownColors.FormHeaderDownColor] = Color.DarkRed;
            rgbTable[KnownColors.FormDrawPenColor] = Color.LightPink;
            rgbTable[KnownColors.FormMouseHoverColor] = Color.Orange;
            rgbTable[KnownColors.FormMousePressColor] = Color.OrangeRed;
            //Grouper
            rgbTable[KnownColors.GrouperBorderColor] = Color.Maroon;
            rgbTable[KnownColors.GrouperTextColor] = Color.Black;
            rgbTable[KnownColors.GrouperBackColor] = Color.Transparent;
            //Label 
            rgbTable[KnownColors.LabelTextColor] = Color.Black;
            //ListBox 
            rgbTable[KnownColors.ListBoxBorderColor] = Color.Maroon;
            rgbTable[KnownColors.ListBoxSelectedColor] = Color.FromArgb(255, 218, 114);

            //RadioButton
            rgbTable[KnownColors.RadioButtonBaseColor] = Color.Maroon;
            rgbTable[KnownColors.RadioButtonTextColor] = Color.Black;
            //TabControl
            rgbTable[KnownColors.TabControlBackColor] = Color.Transparent;
            rgbTable[KnownColors.TabControlBorderColor] = Color.Maroon;
            rgbTable[KnownColors.TabControlPageTextColor] = Color.Black;
            rgbTable[KnownColors.TabControlPageBackColor] =Color.Transparent;//Color.FromArgb(255, 234, 247, 254);
            rgbTable[KnownColors.TabControlPageNormalBackColor1] = Color.PaleVioletRed;
            rgbTable[KnownColors.TabControlPageNormalBackColor2] = Color.IndianRed;
            rgbTable[KnownColors.TabControlPageNormalBackColor3] = Color.Crimson;
            rgbTable[KnownColors.TabControlPageNormalBackColor4] = Color.Firebrick;
            rgbTable[KnownColors.TabControlPageNormalBackColor5] = Color.Maroon;

            rgbTable[KnownColors.TabControlPageHoverColor1] = Color.FromArgb(255, 255, 253, 238);
            rgbTable[KnownColors.TabControlPageHoverColor2] = Color.FromArgb(255, 255, 237, 172);
            rgbTable[KnownColors.TabControlPageHoverColor3] = Color.FromArgb(255, 255, 224, 131);
            rgbTable[KnownColors.TabControlPageHoverColor4] = Color.FromArgb(255, 255, 229, 155);
            rgbTable[KnownColors.TabControlPageHoverColor5] = Color.FromArgb(255, 255, 200, 138);

            rgbTable[KnownColors.TabControlPageSelectColor1] = Color.FromArgb(255, 255, 236, 212);
            rgbTable[KnownColors.TabControlPageSelectColor2] = Color.FromArgb(255, 255, 198, 125);
            rgbTable[KnownColors.TabControlPageSelectColor3] = Color.FromArgb(255, 255, 182, 88);
            rgbTable[KnownColors.TabControlPageSelectColor4] = Color.FromArgb(255, 255, 218, 114);
            rgbTable[KnownColors.TabControlPageSelectColor5] = Color.FromArgb(255, 245, 200, 158);
            rgbTable[KnownColors.TreeViewBackColor] = Color.LightPink;

            rgbTable[KnownColors.DateTimePickerBorder] = Color.Maroon;
            #endregion
        }

        #endregion
    }
}
