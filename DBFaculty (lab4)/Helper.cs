using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFaculty__lab4_
{
    class Helper
    {
        public static void CorrectName(string name)
        {
            if (name.Contains('0') || name.Contains('1') || name.Contains('2') || name.Contains('3')
                    || name.Contains('4') || name.Contains('5') || name.Contains('6')
                    || name.Contains('7') || name.Contains('8') || name.Contains('9')
                    || name.Contains('*') || name.Contains('!') || name.Contains('?')
                    || name.Contains('@') || name.Contains('&') || name.Contains('#'))
            {
                throw new Exception("Incorrect name");
            }
        }

        public static string  Translate(string eng)
        {
            switch (eng)
            {
                case "Студенти": return "Students";
                case "Викладачі": return "Teachers";
                case "Предмети": return "Subject";
                case "Групи": return "Groups";
                case "Спільні групи": return "CommonGroups";
                case "Пари": return "Lesson";
                case "Кафедри": return "Department";
                default: return eng;
            }
        }

        public static string TableColumnTranslate(string columnName)
        {
            switch (columnName)
            {
                case "st_name": return "Ім'я";
                case "st_nameGr": return "Назва групи";
                case "gr_name": return "Назва групи";
                case "gr_year": return "Курс";
                case "cgr_info": return "INFO";
                case "cgr_nameGr1": return "Назва групи 1";
                case "cgr_nameGr2": return "Назва групи 2";
                case "cgr_nameGr3": return "Назва групи 3";
                case "cgr_nameGr4": return "Назва групи 4";
                case "tc_name": return "Ім'я";
                case "tc_nameDp": return "Кафедра";
                case "ls_nameSb": return "Назва предмету";
                case "ls_aud":  return "Аудиторія 1";
                case "ls_aud2": return "Аудиторія 2";
                case "ls_DOW": return "День тижня";
                case "ls_numLs": return "Номер пари";
                case "dp_name": return "Назва кафедри";
                case "sb_name": return "Назва предмету";
                case "sb_info": return "INFO";
                default: return columnName;
            }
        }
    }

}
