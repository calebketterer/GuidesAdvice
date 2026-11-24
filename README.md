# Guide's Advice

A tModLoader 1.4.5 mod that turns the vanilla Guide into a contextual Terraria progression companion.

## Current prototype

- Preserves the Guide's original randomized opening dialogue and occasionally selects a stage-appropriate custom small-talk line.
- Adds **What's Next?** for the next major progression objective.
- Adds **How do I do that?** for boss encounter and summoning guidance.
- Adds **Hint** for stage-specific randomized hints.
- Tracks shown hint IDs per character and cycles through applicable hints before repeating.
- Keeps the vanilla Guide crafting interaction.

## Adding hints

Hints are organized by progression stage under `Progression/Hints/`.

To add a hint:
1. Open the matching stage file, such as `EarlyPreHardmodeHints.cs`.
2. Add another `new HintDefinition("unique.id", "Hint text.")` entry to its `All` list.
3. If the hint should only appear after a condition is met, provide a third argument containing a condition lambda.

Use a unique ID for every hint. Existing IDs are saved in each character's data to prevent repeats.

## Notes

The progress bar is intentionally not implemented in this prototype. The requested placement is inside the vanilla Guide conversation panel, above the dialogue text. A separate screen overlay would not meet that requirement, so no external HUD has been added.

The source archive intentionally excludes `.git`, `obj`, and `bin`. Keep your existing local `.git` directory when copying these source files into your tModLoader ModSources folder.
