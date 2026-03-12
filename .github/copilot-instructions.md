# Audacia Coding Standards for AI

Source: https://standards.audacia.tech/engineering/coding-standards

## How to apply these rules
- **MUST**: follow by default.
- **SHOULD**: follow unless local codebase conventions or a clear technical reason justify otherwise.
- **COULD**: optional improvement; avoid churn.
- If repo conventions are stricter, follow the repo.
- Separate secure coding and automated testing standards exist but are outside this summary.
- Vue-specific content on the site is not publicly readable; do not invent Vue rules.

## Global principles
- Prefer readability, maintainability, low surprise, and minimal accidental complexity.
- Follow official ecosystem conventions where referenced:
  - TypeScript: Airbnb-style guidance enforced via ESLint where possible.
  - HTML/CSS: Google HTML/CSS Style Guide plus Audacia deviations.
- Prefer KISS, YAGNI, DRY.

## HTML and CSS
### Baseline
- Use Google HTML/CSS Style Guide as the base.
- Audacia deviations:
  - indentation style can follow repo consistency,
  - TODO/action-item comments are discouraged,
  - example markup closes all elements,
  - do not omit optional tags.

### HTML
- Use HTML5.
- Use valid, semantic HTML for its intended purpose.
- Use HTTPS for embedded resources.
- Separate structure, presentation, and behavior.
- Do not use entity references unnecessarily.
- Omit `type` attributes for stylesheets/scripts.
- Avoid unnecessary `id` attributes.
- Use lowercase.
- Remove trailing whitespace.
- Put block/list/table elements on new lines and indent children.
- Use double quotes for attribute values.
- Use UTF-8 without BOM.
- Provide alternative content for multimedia where possible.
- Break long lines and comment only when helpful.

---

## SQL
### Formatting
- Capitalize SQL keywords.
- Use `camelCase` variable names.
- Use single quotes for string literals.
- Put `SELECT` columns on new lines and indent them.
- Put major clauses on new lines.
- Indent key clause bodies.
- Keep most other keywords on the same line when readable.
- Add extra whitespace/new lines only to improve readability.

### Queries
- End every statement with `;`.
- Use full object names.
- Use table aliases, but not SQL Server keywords as aliases.
- Always specify columns in `INSERT` statements.
- Use transactions.
- Prefer `TRY...CATCH` for error handling.
- Use `SET NOCOUNT ON`.
- Avoid cursors, dynamic SQL, `GOTO`, triggers, and `SELECT *`.
- Wrap stored procedure bodies in `BEGIN...END`.
- Prefer table variables where suitable.
- Use `--` comments.
- Avoid joins with subqueries where clearer alternatives exist.
- Use CTEs for complex queries.

### Naming
- Use `PascalCase` for object names.
- Prefix CTEs with `Cte`.
- Start each new CTE on a new line.
- Do not prefix stored procedure names.
- Name objects descriptively.

---

## AI default behavior
- Apply all **MUST** rules automatically.
- Apply **SHOULD** rules unless the repository already uses a stronger or conflicting local convention.
- Use **COULD** rules only when they improve clarity without causing unnecessary churn.
- When information is unavailable from the public site, state that clearly rather than guessing.
