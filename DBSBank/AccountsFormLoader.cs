using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSBank
{
    public class AccountsFormLoader
    {
        public void LoadForm()
        {
            var form = new AccountsListForm();
            form.Refresh();
            form.Show();
            form.RefreshDataGrid();
        }
    }
}
