using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eulei.Map.Code;
using TaskInterface;
using System.IO;
namespace Eulei.Map
{
    public partial class tree : Form
    {
        public List<Organisation> _Organisation;
        public List<VW_Statuion> _VW_Statuion;
        public ImageList il_main = new ImageList();
        /// <summary>
        /// ICO图标
        /// </summary>
        string _ICOPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\ICO.png";
        /// <summary>
        /// 区级图标
        /// </summary>
        string _QbmgPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Qico.png";
        /// <summary>
        /// 市级图标
        /// </summary>
        string _SbmgPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Sico.png";
        /// <summary>
        /// 县级图标
        /// </summary>
        string _XbmgPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Xico.png";
        public tree()
        {
            InitializeComponent();
            this._Organisation = Task.Init().TaskStation.GetOrganisationList();
            this._VW_Statuion = Task.Init().TaskStation.GetVW_StatuionList();
            this.Init();
        }
        public void Init()
        { 
            this.treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(
                (sender1, e1) =>
                {
                    var item1 = e1.Node.Tag as VW_Statuion;
                    if (item1 != null)
                    {
                        MessageBox.Show(item1.Name);
                    }
                }
                );


            if (File.Exists(this._ICOPath))
            {
                Image _im = Image.FromFile(_ICOPath);
                this.il_main.Images.Add("ICO", _im);
                this.il_main.ImageSize = new Size(22, 32);
            }
            else
            {
                MessageBox.Show("Qico图标缺失！");
            }
            if (File.Exists(this._SbmgPath))
            {

                Image _im = Image.FromFile(_SbmgPath);
                this.il_main.Images.Add("Sico", _im);
                this.il_main.ImageSize = new Size(22, 32);
            }
            else
            {
                MessageBox.Show("Sico图标缺失！");
            }
            if (File.Exists(this._QbmgPath))
            {
                Image _im = Image.FromFile(_QbmgPath);
                this.il_main.Images.Add("Qico", _im);
                this.il_main.ImageSize = new Size(22, 32);
            }
            else
            {
                MessageBox.Show("Qico图标缺失！");
            }
            if (File.Exists(this._XbmgPath))
            {
                Image _im = Image.FromFile(_XbmgPath);
                this.il_main.Images.Add("Xico", _im);
                this.il_main.ImageSize = new Size(22, 32);
            }
            else
            {
                MessageBox.Show("Xbmg图标缺失！");
            }
            this.treeView1.ImageList = this.il_main;
            this.treeView1.LineColor = Color.Blue;
            this.treeView1.FullRowSelect = true;

            this.treeView1.ShowLines = true;
            this.treeView1.ShowRootLines = true;
            foreach (var item in this._Organisation)
            {
                var chinden = this._VW_Statuion.Where(m => m.OrganisationID.Equals(item.ID));
                TreeNode root = new TreeNode();
                root.Text = item.Name + "--(" + chinden.Count().ToString() + "家)";
                root.Tag = item;
                root.ImageKey = "ICO";
                root.SelectedImageKey = "ICO";
                foreach (var chinder in chinden)
                {
                    TreeNode node = new TreeNode();
                    node.Text = chinder.Name + "(" + chinder.ImageName + ")";
                    node.Tag = chinder;
                    node.ImageKey = chinder.ImageName;
                    node.SelectedImageKey = chinder.ImageName;
                    root.Nodes.Add(node);
                }
                this.treeView1.Nodes.Add(root);
            }
        }
    }
}
