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
- **Description**: Simplification of interaction with player values.
- **Variables**:
  - `Stress`: Changes player's stress.
  - `Fatigue`: Changes player's fatigue.
  - `Hunger`: Changes player's hunger.
  - `Thirst`: Changes player's thirst.
  - `DrunkEffect`: Changes player's drunk level.
  - `Money`: Changes player's money.
  - `Urine`: Changes player's urine.
  - `Dirtiness`: Changes player's dirtiness.
  - `Weight`: Changes player's weight.
  - `KeyFerndale`: Changes whether the player has a key to Ferndale.
  - `KeyGifu`: Changes whether the player has a key to Gifu.
  - `KeyHome`: Changes whether the player has a key to Home.
  - `KeySatsuma`: Changes whether the player has a key to Satsuma.
  - `KeyRuscko`: Changes whether the player has a key to Ruscko.
  - `CurrentVehicle`: Changes player's CurrentVehicle name.
  - `GUIinteraction`: Changes GUI Interaction.
  - `GUIsubtitle`: Changes GUI Subtitle.
  - `GUIGear`: Changes GUI Gear.
  - `PlayerStop`: Changes player's stop.
  - `Seat`: Changes player's sitting status.

## `MoveDownInCar`
- **Description**: This script manages the player's state when entering or exiting a vehicle. It sets a boolean variable indicating whether the player is in the car.
- **Methods**:
  - `OnTriggerEnter(Collider other)`: Triggered when another collider enters the trigger collider attached to the GameObject. If the collider belongs to the player, it sets the `PlayerInCar` variable to `true`.
  - `OnTriggerExit(Collider other)`: Triggered when another collider exits the trigger collider attached to the GameObject. If the collider belongs to the player, it sets the `PlayerInCar` variable to `false`.

[View full examples](ExampleMod/UtilsExample.cs)