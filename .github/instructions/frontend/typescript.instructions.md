---
description: 'Guidelines for TypeScript Development targeting TypeScript 5.x and ES2022 output'
applyTo: '**/*.ts'
---

## How to apply these rules
- **MUST**: follow by default.
- **SHOULD**: follow unless local codebase conventions or a clear technical reason justify otherwise.
- **COULD**: optional improvement; avoid churn.
- If repo conventions are stricter, follow the repo.
- Separate secure coding and automated testing standards exist but are outside this summary.

## Global principles
- Prefer readability, maintainability, low surprise, and minimal accidental complexity.
- Follow official ecosystem conventions where referenced:
  - C#: Microsoft conventions and framework guidance.
- Prefer KISS, YAGNI, DRY.

## TypeScript
### General
- Prefer explicit, readable typing.
- Annotate function parameters and return types.
- Add explicit types where inference is unclear.
- Prefer `const` over `let`.
- Use interfaces for object shapes.
- Use classes where object/class modeling is intended.
- Prefer `unknown` over `any`.
- Prefer `readonly` for immutable properties.
- Prefer `undefined` over `null`.
- Prefer optional parameters over overloads differing only by trailing args.

### Maintainability
- Keep methods to **10 statements or fewer**.
- Do not duplicate code.
- Limit nested control depth to **2**.
- Do not exceed **4 parameters**.
- Do not use magic numbers or strings.
- Use enums for fixed sets of constants.
- Allow gaps in enum numeric values.
- Do not comment out code.
- Pin or explicitly range dependency versions in `package.json`.
- Implement error logging for observability.
- Prefer one type per file.
- Enable `strictNullChecks`.
- Optimize imports.

### Naming
- File pattern: `{description}.{type}.{extension}`.
- Use conventional file suffixes.
- Use `PascalCase` for symbols.
- Do not prefix private properties.
- Components: kebab-case selectors/files, class ends with `Component`.
- Directives: camelCase selectors, class ends with `Directive`.
- Pipes: camelCase names, class ends with `Pipe`.
- Modules: class ends with `Module`.
- Prefix component/directive/pipe selectors meaningfully.
- Name modules after their feature/folder.

### Performance
- Lazy-load non-critical resources.

### Angular
- Keep component HTML and styles in separate files.
- Put functionality under a `components` folder.
- Group methods and properties.
- Include a `SharedModule`.
- Prefer including `CommonModule`.
- Feature module name should match its parent directory.
- Feature modules should have their own routing module.
- Include a `CoreModule`.
- Single-use components should be declared in `CoreModule`.
- Prefer `providedIn` over manually populating `providers`.
- Avoid re-importing single-use modules.

### Vue
- Public overview exists, but detailed rules are behind login.
- Do not infer or fabricate Vue-specific standards from this site.

## AI default behavior
- Apply all **MUST** rules automatically.
- Apply **SHOULD** rules unless the repository already uses a stronger or conflicting local convention.
- Use **COULD** rules only when they improve clarity without causing unnecessary churn.
- When information is unavailable from the public site, state that clearly rather than guessing.