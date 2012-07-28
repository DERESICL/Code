    <h2>Departments</h2> 
    <asp:ObjectDataSource ID="BookingssObjectDataSource" runat="server"  
        TypeName="ContosoUniversity.DAL.SchoolRepository" DataObjectTypeName="BookEasy.DAL.Booking" 
        InsertMethod="InsertBooking" > 
    </asp:ObjectDataSource> 
    <asp:DetailsView ID="BookingsDetailsView" runat="server"  
        DataSourceID="BookingsObjectDataSource" AutoGenerateRows="False" 
        DefaultMode="Insert" OnItemInserting="BookingsDetailsView_ItemInserting"> 
        <Fields> 
            <asp:DynamicField DataField="customername" HeaderText="Name" /> 
            <asp:DynamicField DataField="address" HeaderText="Budget" /> 
            <asp:DynamicField DataField="StartDate" HeaderText="Start Date" /> 
            <asp:TemplateField HeaderText="Administrator"> 
                <InsertItemTemplate> 
                    <asp:ObjectDataSource ID="HolidayhomeObjectDataSource" runat="server"  
                        TypeName="BookEasy.DAL.HolidayhomeRepository"  
                        DataObjectTypeName="BookEasy.DAL.OwnerName" 
                        SelectMethod="GetOwnerNames" > 
                    </asp:ObjectDataSource> 
                    <asp:DropDownList ID="OwnersDropDownList" runat="server"  
                        DataSourceID="OwnersObjectDataSource" 
                        DataTextField="FullName" DataValueField="PersonID" OnInit="BookingsDropDownList_Init"> 
                    </asp:DropDownList> 
                </InsertItemTemplate> 
            </asp:TemplateField> 
            <asp:CommandField ShowInsertButton="True" /> 
        </Fields> 
    </asp:DetailsView> 
   <asp:ValidationSummary ID="BookingsValidationSummary" runat="server"  
        ShowSummary="true" DisplayMode="BulletList"  />

