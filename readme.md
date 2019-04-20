# C# Record Generator
Inspired by C# 8.0 upcomming record syntax, this is a program that lets you quickly generate record classes.

## Adding fields
Use the data grid entry to add fields to your record class.
* **Datatype** will be the type of the field
* **Identifier** will be the name of the field and constructor parameter
* **ROnly** will make the field read-only

## Generator options
Use the bottom left panel to customize the output of the generator
* **Generate with properties** will generate properties instead of fields.
* **Struct** will generate a `struct` instead of a `class`
* **Generate Equality Operators** will auto-implement `==`, `!=`, `Equals()` and `GetHashCode()` for you

Press the "generate" button to generate your output and "Copy All" to copy the output to your clipboard.