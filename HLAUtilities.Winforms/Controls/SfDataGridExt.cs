using DevExpress.Xpo;
using Syncfusion.WinForms.DataGrid;
using System.ComponentModel;
using System.Data;
using System.Linq;


namespace HLAToools.Winforms.Controls
{
    public class SfDataGridExt : SfDataGrid
    {
        private object itemSource;

        [Category("Data")]
        [Description("Specifies a collection that is used to generate the content of the SfDataGrid.")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.All)]
        [TypeConverter("System.Windows.Forms.Design.DataSourceConverter, System.Design")]
        [Cloneable(false)]
        public object ItemSource
        {
            get
            {
                return itemSource;
            }

            set
            {
                if (value != itemSource)
                {
                    itemSource = value;
                    this.OnItemSourceChanged(value);
                }

            }
        }

        public SfDataGridExt()
        {

        }

        protected virtual void OnItemSourceChanged(object newValue)
        {
            //Type cast to Resolve the reported problem and set to SfDataGrid DataSource property 
            DataSource = (ItemSource as XPCollection).Cast<object>();
        }
    }

}
