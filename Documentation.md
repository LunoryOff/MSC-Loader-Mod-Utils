# MSCLoader Mod Utils Documentation

## `ReactiveValue<T>`
- **Description**: Notifies when the value changes.
- **Methods**:
  - `Value`: Get/set the value (triggers event on change).

## `ConsoleTools`
- **Methods**:
  - `Log()`: Customizable console messages.
  - `LogSuccess()`, `LogInfo()`, `LogError()`: Pre-styled logs.

## `ObjectPool<T>`
- **Description**: Recycles GameObjects/Components.
- **Methods**:
  - `GetObject()`: Retrieve an object from the pool.
  - `ReturnObject()`: Return an object to the pool.

[View full examples](ExampleMod/)
