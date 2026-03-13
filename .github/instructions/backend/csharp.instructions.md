---
description: 'Guidelines for building C# applications'
applyTo: '**/*.cs'
---

### Design
- Single responsibility for classes/interfaces.
- Keep interfaces small and focused.
- Use interfaces to decouple implementations.
- Prefer interfaces over base classes for multiple implementations.
- Do not hide inherited members with `new`.
- Do not reference derived types from base classes.
- Avoid bidirectional dependencies.
- Use `record` for data-only types.
- Apply code-formatting style defined in `.editorconfig`.

### Maintainability
- Keep methods to **10 statements or fewer**.
- Default to **`private` members** and **`internal` types**.
- Do not use magic numbers.
- Keep one variable assignment per statement.
- Avoid explicit `== true` / `== false` checks.
- Do not mutate loop variables inside `for` / `foreach`.
- Always use braces for control flow.
- Always include a `default` branch in `switch`.
- Extract complex expressions into a method/property.
- Do not exceed **4 parameters**.
- Avoid `ref`, `out`, and boolean flag parameters.
- Prefer pattern matching with `is` over `as`.
- Do not leave commented-out code.
- Enable nullable reference types.
- Prefer switch expressions.
- Prefer using declarations.
- Prefer object/collection initializers.
- Avoid nested loops, double negatives, and unnecessary multiple returns.

### Member design
- Properties should be settable in any order.
- Use a method instead of a property when it performs work.
- Do not use mutually exclusive properties.
- Each method/property should do one thing.
- Use `init` setters for values that should be immutable after initialization.
- Prefer returning `IEnumerable<T>` / `ICollection<T>` over concrete collections.
- Strings and collections should not be `null`.
- Use the most specific parameter types possible.
- Consider domain-specific value types over primitives when helpful.

### Framework and layout
- Use C# aliases like `int`, `string`, `bool` instead of `System.*` names.
- Do not hardcode deployment-dependent strings.
- Build at the highest warning level.
- Use `dynamic` only when truly required.
- Prefer `async` / `await` over low-level `Task` composition.
- Use a consistent file layout and defined member ordering.
- Avoid `#region` unless clearly justified.
- Use file-scoped namespaces.
- Prefer global and implicit usings where appropriate.

### Documentation and exceptions
- Comment only complex algorithms or non-obvious decisions.
- Do not use comments for TODO/work tracking.
- Public/internal/protected API docs are optional but helpful.
- Throw exceptions rather than status values where appropriate.
- Use specific exception types and meaningful messages.
- Do not swallow generic exceptions.
- Null-check event handlers and do not raise events with a `null` sender.
- Materialize LINQ results before returning when deferred execution would be risky.

### Data access and performance
- Prefer Entity Framework Core.
- Use `AsNoTracking()` for read-only EF queries.
- Configure maximum string lengths in EF mappings.
- Prefer eager loading and returning `IEnumerable` over leaking `IQueryable`.
- Use `Any()` to test whether an `IEnumerable<T>` is empty.
- Use async mainly for I/O.
- Prefer `Task.Run` for CPU-bound work when needed.
- Avoid mixing `await` with blocking waits like `Task.Wait()`.

### Naming
- Use descriptive names and correct casing.
- Do not use numbers in variables, parameters, or members.
- Do not prefix fields.
- Do not repeat class/enum names in member names.
- Keep naming aligned with related .NET APIs.
- Use noun/adjective names for types and verb-object names for methods.
- Name namespaces by name/layer/verb/feature.
- Name boolean members consistently.
- Name events correctly; prefix event raisers/handlers with `On`.
- Use `_` for intentionally ignored lambda parameters.
- Put extension methods in classes ending with `Extensions`.
- Suffix async methods with `Async` or `TaskAsync`.
- Avoid vague “Data”-like suffixes in entity names.