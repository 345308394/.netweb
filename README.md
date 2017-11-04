# .netweb
注意要把一个控件的autopostback属性设置为true

首先拖动两个DropDownList控件
在代码中定义两个函数



在第一个DropDownList控件添加数据
 protected void DropdownList1()
    {
        DropDownList1.Items.Add(new ListItem("山东省"));
        DropDownList1.Items.Add(new ListItem("河南省"));
    }

第二个函数根据第一个控件中的数据更换第二个控件中的数据
protected void DropdownList2()
{
  switch(DropDownList1.SelectedValue)
  {case"山东省":
     DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem("济宁市"));
                DropDownList2.Items.Add(new ListItem("菏泽市"));
                DropDownList2.Items.Add(new ListItem("济南市"));
                break;
   case"河南省":
     DropDownList2.Items.Clear();
                 DropDownList2.Items.Add(new ListItem("商丘"));
                DropDownList2.Items.Add(new ListItem("郑州"));        
                break;
   
  }
}

第一个控件变化时发生的函数
protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropdownList2();

    }

页面加载函数
 protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropdownList1();
            DropdownList2();
        }

    }
如果不是自动回调就执行此函数
