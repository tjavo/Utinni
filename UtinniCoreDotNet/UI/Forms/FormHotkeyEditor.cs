﻿/**
 * MIT License
 *
 * Copyright (c) 2020 Philip Klatt
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
**/

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;

namespace UtinniCoreDotNet.UI.Forms
{
    public partial class FormHotkeyEditor : UtinniForm
    {
        private bool hasChanges;
        public bool HasChanges
        {
            get { return hasChanges; }
            set
            {
                hasChanges = value;
                btnSave.Enabled = hasChanges;
            }
        }

        private readonly HotkeyManager mainHotkeyManager;
        private readonly List<IEditorPlugin> editorPlugins;
        private readonly SubPanelContainer spnlContainer = new SubPanelContainer("Hotkeys");

        public FormHotkeyEditor(HotkeyManager mainHotkeyManager, List<IEditorPlugin> editorPlugins)
        {
            InitializeComponent();
            this.mainHotkeyManager = mainHotkeyManager;
            this.editorPlugins = editorPlugins;

            TopMost = true;

            spnlContainer.Dock = DockStyle.Fill;

            CreateControls();
        }

        private void CreateControls()
        {
            spnlContainer.Controls.Add(CreatePanel("Utinni", mainHotkeyManager));

            foreach (IEditorPlugin editorPlugin in editorPlugins)
            {
                HotkeyManager hotkeyManager = editorPlugin.GetHotkeyManager();

                if (hotkeyManager != null)
                {
                    spnlContainer.Controls.Add(CreatePanel(editorPlugin.Information.Name, hotkeyManager));
                }
            }

            Controls.Add(spnlContainer);
            spnlContainer.Size = new Size(700, 546);
            spnlContainer.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private CollapsiblePanel CreatePanel(string text, HotkeyManager hotkeyManager)
        {
            SubPanel spnl = new SubPanel("", true, false);

            int yOffset = 3;
            foreach (var hotkeyEntry in hotkeyManager.Hotkeys)
            {
                UtinniLabel lbl = new UtinniLabel
                {
                    Text = hotkeyEntry.Value.Text, 
                    Location = new Point(0, yOffset),
                    Width = 350
                };

                UtinniButton btn = new UtinniButton
                {
                    Width = 350,
                    Text = hotkeyEntry.Value.GetKeyComboString(),
                    Location = new Point(350, yOffset),
                };

                btn.Click += (sender, args) =>
                {
                    FormHotkeyEditorDialog form = new FormHotkeyEditorDialog(hotkeyEntry.Value);
                    form.Top = (this.Top + (this.Height / 2)) - form.Height / 2;
                    form.Left = (this.Left + (this.Width / 2)) - form.Width / 2;
                    DialogResult dialogResult = form.ShowDialog(this);
                    if (dialogResult == DialogResult.OK)
                    {
                        hotkeyEntry.Value.UpdateKeys(form.NewValue);
                        btn.Text = form.NewValue;
                        HasChanges = true; // ToDo have HasChanges specific to each hotkeyManager and only save those that are changed?
                    }
                };

                spnl.Controls.Add(lbl);
                spnl.Controls.Add(btn);

                yOffset += 23;
            }
            spnl.Height = yOffset + 23;

            var cpnl = new CollapsiblePanel(spnl, text, 700)
            {
                Margin = new Padding(0, 3, 0, 3),
                Height = spnl.Height + 3
            };

            return cpnl;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to Save?", "Confirm Save", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.Yes)
            {
                mainHotkeyManager.Save();

                foreach (IEditorPlugin editorPlugin in editorPlugins)
                {
                    HotkeyManager hotkeyManager = editorPlugin.GetHotkeyManager();

                    if (hotkeyManager != null)
                    {
                        hotkeyManager.Save();
                    }
                }
            }
        }
    }
}
