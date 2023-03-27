<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dbConnectionToLdb.aspx.cs" Inherits="WebApplicationCon.dbConnectionToLdb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
         <%--   <h1>Database connection working</h1>--%>

      <h2> Database connection learning</h2>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
      
            <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:LDbConStr %>" ProviderName="<%$ ConnectionStrings:LDbConStr.ProviderName %>" SelectCommand="SELECT * FROM [employees]" ID="ctl01"></asp:SqlDataSource>
          
        </div>
    </form>
</body>
</html>
