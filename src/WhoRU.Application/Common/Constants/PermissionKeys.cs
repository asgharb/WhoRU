namespace WhoRU.Application.Common.Constants
{
    public static class PermissionKeys
    {
        // صفحهها یا کنترلرهای کلیدی
        public const string ProductsPage = "Pages.Products";
        public const string OrdersPage = "Pages.Orders";
        public const string UsersPage = "Pages.Users";
        public const string RolesPage = "Pages.Roles";

        // عملیات CRUD به صورت کلیدهای permission داینامیک
        public const string Create = "Create";
        public const string Read = "Read";
        public const string Update = "Update";
        public const string Delete = "Delete";

        // مجوزهای ترکیبی یا ویه
        public const string AdminAccess = "AdminAccess";
        public const string ManageNotifications = "ManageNotifications";

        // کلیدهای عمومی دسترسی (قابل گسترش)
    }
}
