# Лабораторна робота №1: Система обліку зоопарку

**Мета роботи:** Навчитися дотримуватися принципів програмування (DRY, KISS, SOLID, YAGNI тощо).

## Структура проекту

KPZ_2025_ALM/
└── lab-1-zoo/
└── zoo/
├── Interfaces/
│ └── IReportable.cs
├── Models/
│ ├── Animal.cs
│ ├── Enclosure.cs
│ ├── Feed.cs
│ └── Staff.cs
├── Services/
│ └── InventoryReporter.cs
├── Program.cs
└── zoo.csproj
---

## 1. Опис дотримання принципів програмування

1. **DRY (Don't Repeat Yourself)**  
   Винесено інтерфейс `IReportable` в окремий файл **Interfaces/IReportable.cs**, щоб уникнути дублювання методу `GetReport()`.

2. **KISS (Keep It Simple, Stupid)**  
   Клас `Animal` зберігає тільки дані про тварину; `Enclosure` — дані про вольєр; `Feed` — дані про корм; `Staff` — дані про працівника; `InventoryReporter` формує звіт.

3. **SOLID**  
   - **S** (Single Responsibility): кожен клас виконує лише одну відповідальність.  
   - **O** (Open/Closed): можна додати нові реалізації `IReportable` без зміни існуючого коду.  
   - **L** (Liskov Substitution): будь-яка реалізація `IReportable` може замінити іншу.  
   - **I** (Interface Segregation): `IReportable` містить лише метод, необхідний для звітування.  
   - **D** (Dependency Inversion): `Program.cs` залежить від абстракції `IReportable`, а не від конкретного класу.

4. **YAGNI (You Aren't Gonna Need It)**  
   У коді реалізовано лише необхідну для роботи логіку без зайвого функціоналу.

5. **Composition over Inheritance**  
   `InventoryReporter` отримує сервіси та дані через конструктор (композиція), а не наслідується від них.

6. **Program to Interfaces, not Implementations**  
   Змінна звітності оголошена як `IReportable reporter`, а не як конкретний клас.

7. **Fail Fast**  
   Якщо передати в `InventoryReporter` некоректні дані (null-колекції), програма завершиться помилкою одразу.

---

## 2. Запуск проекту
1. Відкрити рішення `KPZ_2025_ALM.sln` в Visual Studio.  
2. Встановити проект **zoo** як стартовий.  
3. Переконатися, що в `Program.cs` встановлено `Console.OutputEncoding = Encoding.UTF8`.  
4. Зібрати та запустити (Ctrl+F5).

## 3. Запуск тестів
1. Відкрити **Test Explorer**.  
2. Натиснути **Run All**.

---

## 4. UML-діаграма
![UML-діаграма](./lab-1-zoo/zoo/лаб1.drawio.png)
*Кінець README*
