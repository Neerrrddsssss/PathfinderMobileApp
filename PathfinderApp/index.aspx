<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PathfinderApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Character Sheet</title>
    <script src="js/jquery-3.1.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="mainDiv">
          <div id="divCharInfo" class="col-md-12 col-xs-12 text-center">
              <img src="images/header.png"/>
          </div>
        <asp:DropDownList runat="server" ID="ddlRace"></asp:DropDownList>
        <asp:DropDownList runat="server" id="ddlClass"></asp:DropDownList>
       <asp:Button Text="Test Create a char" runat="server" ID="btnCreateChar" CssClass="btn btn-default" OnClick="btnCreateChar_Click"/>

        <asp:ListBox runat="server" ID="lbChar">

        </asp:ListBox>
    </div>
    </form>
</body>
</html>
