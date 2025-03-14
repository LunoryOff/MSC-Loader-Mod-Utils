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

## `PlayerValues`
- **Description**: Simplification of interction with player values.
- **Variables**:
  - `Stress`: Changes player's stress.
  - `Fatigue`: Changes player's fatigue.
  - `Hunger`: Changes player's hunger.
  - `Thirst`: Changes player's thirst.
  - `DrunkEffect`: Changes player's drunk level.
  - `Money`: Changes player's money.

  ## `GUIStates`
- **Description**: Simplification of interction with GUI states.
- **Variables**:
  - `Use`: Adds "Use" interaction to object.
  - `Assemble`: Adds "Assemble" interaction to object.
  - `Disassemble`: Adds "Disassemble" interaction to object.
  - `Buy`: Adds "Buy" interaction to object.
  - `Drive`: Adds "Drive" interaction to object.
  - `PassengerSeat`: Adds "Passenger Seat" to the object.
  - `InteractionText`: Adds "Interaction Text" to the object.
  - `SubtitleText`: Adds "Subtitle Text" to the object.

[View full examples](ExampleMod/UtilsExample.cs)
