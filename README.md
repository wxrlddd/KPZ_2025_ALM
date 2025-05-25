KPZ_2025_ALM/
└── lab-1-zoo/
    └── zoo/
        ├── Interfaces/IReportable.cs
        ├── Models/
        │   ├── Animal.cs
        │   ├── Enclosure.cs
        │   ├── Feed.cs
        │   └── Staff.cs
        ├── Services/InventoryReporter.cs
        ├── Program.cs
        └── zoo.csproj
```\n
---\n
## Опис дотримання принципів програмування

У цій секції наведено приклад реалізації кожного принципу, який демонструється в коді.

1. **DRY (Don't Repeat Yourself)**\n   - Виділено інтерфейс `IReportable` в **Interfaces/IReportable.cs**, щоб уніфікувати та переиспользувати метод `GetReport()` для різних реалізацій звітності ([IReportable.cs](./zoo/Interfaces/IReportable.cs)).\n

2. **KISS (Keep It Simple, Stupid)**\n   - Кожен клас виконує лише одну просту задачу: `Animal` зберігає дані про тварину, `Enclosure` — про вольєр, `Feed` — про корм, `Staff` — про персонал, `InventoryReporter` — формує звіт.\n   \n
3. **SOLID**\n   - **S** (Single Responsibility):\n     - Клас `InventoryReporter` відповідає тільки за побудову звіту ([InventoryReporter.cs#L1-L5](./zoo/Services/InventoryReporter.cs#L1-L5)).\n   - **O** (Open/Closed):\n     - Можна додавати нові типи звітів, реалізуючи `IReportable`, без змін у класі звітування.\n   - **L** (Liskov Substitution):\n     - Будь-яка реалізація `IReportable` може замінити `InventoryReporter` у `Program.cs` без поломки логіки.\n   - **I** (Interface Segregation):\n     - Інтерфейс `IReportable` містить тільки один метод `GetReport()`, вузькоспрямований на потреби звітності.\n   - **D** (Dependency Inversion):\n     - `Program.cs` залежить не від конкретного класу звіту, а від абстракції `IReportable`: `IReportable reporter = new InventoryReporter(...);` ([Program.cs#L20](./zoo/Program.cs#L20)).\n

4. **YAGNI (You Aren't Gonna Need It)**\n   - Ніяких зайвих методів або полів у класах не створено — лише необхідне.

5. **Composition over Inheritance**\n   - Клас `InventoryReporter` отримує колекції моделей (`List<Animal>`, `List<Staff>`, `List<Enclosure>`, `List<Feed>`) через конструктор, а не наслідується від них. ([InventoryReporter.cs#L7-L10](./zoo/Services/InventoryReporter.cs#L7-L10)).\n

6. **Program to Interfaces, not Implementations**\n   - В `Program.cs` застосовано тип `IReportable` для змінної, а не конкретний клас: `IReportable reporter = new InventoryReporter(...);`\n

7. **Fail Fast**\n   - Конструктор `InventoryReporter` не перехоплює помилки при null-колекціях — якщо передати null, програма впаде відразу, що дозволяє швидко виявити проблему.

---\n
**Запуск проекту:**\n1. Відкрити рішення `KPZ_2025_ALM.sln` в Visual Studio.\n2. Встановити проект `zoo` як стартап.\n3. Налаштувати `Console.OutputEncoding = UTF8` в `Program.cs`.\n4. Збірка та запуск (Ctrl+F5).\n

**Запуск тестів:**\n1. Відкрити Test Explorer.\n2. Натиснути "Run All".\n

---\n
*Кінець README*