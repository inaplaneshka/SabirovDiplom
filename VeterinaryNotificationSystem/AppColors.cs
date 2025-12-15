using System.Drawing;

namespace VeterinaryNotificationSystem
{
    public static class AppColors
    {
        // Основные цвета ветеринарной тематики
        public static Color PrimaryColor = Color.FromArgb(46, 125, 50); // Зеленый
        public static Color PrimaryLight = Color.FromArgb(129, 199, 132);
        public static Color PrimaryDark = Color.FromArgb(27, 94, 32);
        public static Color SecondaryColor = Color.FromArgb(33, 150, 243); // Синий
        public static Color SecondaryLight = Color.FromArgb(100, 181, 246);
        public static Color SecondaryDark = Color.FromArgb(13, 71, 161);

        // Дополнительные цвета
        public static Color SuccessColor = Color.FromArgb(56, 142, 60);
        public static Color WarningColor = Color.FromArgb(255, 152, 0);
        public static Color DangerColor = Color.FromArgb(211, 47, 47);
        public static Color InfoColor = Color.FromArgb(2, 136, 209);

        // Фоновые цвета
        public static Color BackgroundLight = Color.FromArgb(250, 250, 250);
        public static Color BackgroundDark = Color.FromArgb(66, 66, 66);
        public static Color PanelBackground = Color.FromArgb(245, 245, 245);

        // Текст
        public static Color TextPrimary = Color.FromArgb(33, 33, 33);
        public static Color TextSecondary = Color.FromArgb(117, 117, 117);
        public static Color TextLight = Color.White;

        // Цвета для статусов
        public static Color StatusSent = Color.FromArgb(56, 142, 60);
        public static Color StatusPending = Color.FromArgb(255, 152, 0);
        public static Color StatusFailed = Color.FromArgb(211, 47, 47);
        public static Color StatusDraft = Color.FromArgb(117, 117, 117);
        public static Color StatusScheduled = Color.FromArgb(33, 150, 243);

        // Цвета для таблиц
        public static Color TableHeader = Color.FromArgb(46, 125, 50);
        public static Color TableRowEven = Color.FromArgb(250, 250, 250);
        public static Color TableRowOdd = Color.White;
        public static Color TableSelection = Color.FromArgb(129, 199, 132);
    }
}