# MSC-Loader-Mod-Utils
A utility library for simplifying mod development in My Summer Car (MSCLoader).

## Features
- **Reactive Values**: Event-driven value tracking.
- **Console Tools**: Rich text logging with colors, sizes, and styles.
- **Coroutine Runner**: Safe coroutine execution outside MonoBehaviour.
- **Object Pooling**: Efficient GameObject/Component reuse.
- **Mesh Replacement**: Easy mesh/material swapping.

## Installation
1. Download the latest release.
2. Add `ModUtils.dll` to your mod project references.

## Quick Start
```csharp
// Log a message with custom style
ConsoleTools.LogSuccess("Hello, MSC!");

// Create a reactive integer
ReactiveValue<int> health = new ReactiveValue<int>();
health.ValueChanged += (val) => Console.Log($"Health: {val}");
health.Value = 100;
