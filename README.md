# Data Medical Software (Inventory Management System)

This is an in-house inventory management system built using ASP.NET Core Razor Pages, Entity Framework Core, and SQL Server (LocalDB).

---

## 📦 Technologies Used

- ASP.NET Core Razor Pages (.NET 6/7)
- Entity Framework Core (EF Core)
- SQL Server LocalDB (via SQL Server Object Explorer)
- Visual Studio 2022 or later

---

## ⚙️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/mzayem/Data-InHouse-Softwere.git
cd Data-InHouse-Softwere
```

---

### 2. Setup Database

#### Install Required NuGet Packages

Use **Package Manager Console** in Visual Studio or `dotnet add package` in terminal:

```powershell
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
```

Or with .NET CLI:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

---

### 3. Configure Connection String

Update `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=InventoryDb;Trusted_Connection=True;"
}
```

---

### 4. Create Initial Migration and Update Database

Use the **Package Manager Console**:

```powershell
Add-Migration InitialCreate
Update-Database
```

If using CLI:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🧾 Example Model

```csharp
public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}
```

---

## 🔧 Project Structure

```
/data-medical-softwere
│
├── Modals/              → EF Core Models
├── Pages/Groups/        → Razor Pages for Group entity
├── Program.cs           → Main application setup
├── AppDbContext.cs      → EF Core DbContext
├── appsettings.json     → Configuration including DB
└── README.md            → You're reading it
```

---

## 💡 Useful Commands

- `dotnet restore` – Restore NuGet packages
- `dotnet build` – Build the project
- `dotnet ef migrations add <Name>` – Add EF Core migration
- `dotnet ef database update` – Apply migrations to DB

---

## ✨ Features Planned

- Group Entry and Management ✅
- Product Categories
- Stock In/Out
- Reporting
- User Roles

---

## 🤝 Contributing

Pull requests are welcome. For major changes, please open an issue first.

---

## 📄 License

[MIT](https://github.com/mzayem/data-medical-softwere/blob/master/LICENSE)
