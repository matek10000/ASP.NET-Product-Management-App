# Aplikacja ASP.NET - Zarządzanie produktami


Lista technologii: 
- .NET 6.0
- SQLite
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.AspNetCore.Identity.UI
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Sqlite.Core
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.NET.Test.Sdk
- Microsoft.VisualStudio.Web.CodeGeneration.Design
- xunit
- xunit.runner.visualstudio
- coverlet.collector
 

Dane logowania dla admina:
Login: mateusz@gmail.com
Hasło: haslo123
 

Proces uruchomienia aplikacji w wersji deweloperskiej:

Wymagane wykonanie migracji, ale poprzez konsolę NuGet:
1. Narzędzia → Menedżer pakietów NuGet → Konsola Menedżera Pakietów
2. Wybrać w konsoli projekt domyślny -  ProductData
3. Komenda do wykonania migracji - “Add-Migration nazwa_migracji”
4. Komenda zatwierdzająca - “Update-Database”
5. GOTOWE!

Własne funkcje:
- Wybór rodzaju wyświetlania listy produktów (stronicowana lub pełny widok)
- Dodanie opcji oznaczenia produktu, którego ilość jest bliska zeru.
