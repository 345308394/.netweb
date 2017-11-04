using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropdownList1();
            DropdownList2();
        }

    }
    protected void DropdownList1()
    {
        DropDownList1.Items.Add(new ListItem("山东省"));
        DropDownList1.Items.Add(new ListItem("河南省"));
    }
    protected void DropdownList2()
    {
        switch (DropDownList1.SelectedValue)
        {
            case "山东省":
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem("济宁市"));
                DropDownList2.Items.Add(new ListItem("菏泽市"));
                DropDownList2.Items.Add(new ListItem("济南市"));
                break;
            case "河南省":
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem("商丘"));
                DropDownList2.Items.Add(new ListItem("郑州"));        
                break;
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropdownList2();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string strName = TextBox1.Text;
        string strPwd = TextBox2.Text;
        string strSex = RadioButtonList1.SelectedItem.Value;
        string strNu = TextBox4.Text;
        string strIdress = DropDownList1.SelectedItem.Value + DropDownList2.SelectedItem.Value;
        string strLike = "";
        foreach (ListItem item in CheckBoxList1.Items)
        {
            if(item.Selected)
            {
                 strLike += item.Value + "";
            }
        }
        Response.Write("用户名："+strName + "<br/>");
        Response.Write("密码：" + strPwd + "<br/>");
        Response.Write("性别：" + strSex + "<br/>");
        Response.Write("地址：" + strIdress + "<br/>");
        Response.Write("身份证号：" + strNu + "<br/>");
        Response.Write("爱好：" + strLike + "<br/>");
    }
}