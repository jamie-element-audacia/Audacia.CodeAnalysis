


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

### Baseline
- Use Google HTML/CSS Style Guide as the base.
- Audacia deviations:
  - indentation style can follow repo consistency,
  - TODO/action-item comments are discouraged,
  - example markup closes all elements,
  - do not omit optional tags.

  ### CSS
- Use valid CSS.
- Use meaningful, concise class names.
- Separate words in class names with hyphens.
- Avoid qualifying class names with element/type selectors.
- Avoid `#id` selectors.
- Use shorthand properties where possible.
- Omit units on zero values.
- Include leading zeroes.
- Prefer 3-character hex values when possible.
- Use HTTPS for embedded resources.
- Use lowercase.
- Avoid `!important` unless genuinely necessary.
- Avoid CSS hacks and user-agent detection.
- Indent block content.
- End every declaration with `;`.
- Put a space after property colons.
- Put a space before declaration blocks.
- Put selectors/declarations/rules on separate lines.
- Use single quotes for attribute selectors and property values.
- Alphabetize declarations when practical.
- Group sections and comment only when helpful.

### CSS selectors for UI automation
- Add selectors to support automated UI tests.
- Use a consistent format.
- Follow the site’s 3-part selector structure:
  - component verb,
  - section,
  - element.
- Use standardized element types.

## AI default behavior
- Apply all **MUST** rules automatically.
- Apply **SHOULD** rules unless the repository already uses a stronger or conflicting local convention.
- Use **COULD** rules only when they improve clarity without causing unnecessary churn.
- When information is unavailable from the public site, state that clearly rather than guessing.