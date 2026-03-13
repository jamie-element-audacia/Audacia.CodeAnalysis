---
description: 'CSS Styling guidelines'
applyTo: '**/*.css'
---

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
