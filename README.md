# WebApplication3

Это веб-приложение на ASP.NET Core, которое предназначено для управления заказами. 
В проекте реализована простая модель заказа и предоставлены возможности для создания и отображения заказов.

## О проекте

Проект использует Entity Framework Core для работы с базой данных PostgreSQL. Модель заказа упрощена, но в идеале должна быть разбита на несколько сущностей для повышения гибкости и удобства. Взаимодействия с данными описаны в контроллере, чтобы избежать избыточного объема и дублирования кода.

## Требования

- [.NET 8.0 или выше](https://dotnet.microsoft.com/download/dotnet)
- [PostgreSQL](https://www.postgresql.org/download/) (для работы с базой данных)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) 

## Установка и запуск

1. **Клонирование репозитория**:
   - Откройте командную строку или PowerShell и выполните:
     ```bash
     git clone https://github.com/Keram-Gog/TeatProject.git
     cd repository-name
     ```

2. **Открытие проекта**:
   - Запустите Visual Studio.
   - Выберите "Открыть проект" и найдите файл `.sln` в папке с клонированным репозиторием.

3. **Настройка строки подключения**:
   - Откройте файл `appsettings.json`.
   - Убедитесь, что строка подключения к PostgreSQL указана верно:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=DelDB;Username=postgres;Password=1234"
     }
     ```

4. **Создание базы данных**:
   - Создайте новую базу данных `DelDB` в PostgreSQL с помощью pgAdmin или командной строки.
   - Убедитесь, что пользователь `postgres` имеет доступ к базе данных.

5. **Установка зависимостей**:
   - В Visual Studio откройте `Package Manager Console` и выполните:
     ```powershell
     dotnet restore
     ```

6. **Применение миграций**:
   - Выполните команды для создания и применения миграции:
     ```powershell
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

7. **Запуск проекта**:
   - В Visual Studio нажмите "Запустить" или используйте клавишу `F5`.

8. **Доступ к приложению**:
   - Откройте браузер и перейдите по адресу `https://localhost:5001`.

## Структура проекта

- **Models**: Классы моделей, такие как `Order`.
- **Data**: `ApplicationDbContext` для работы с базой данных.
- **Controllers**: Контроллеры для обработки запросов.
- **Views**: Представления для отображения информации.

