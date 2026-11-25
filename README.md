# Guide's Advice

A tModLoader 1.4.5 mod that turns the vanilla Guide into a continuously useful Terraria progression companion.

## Installation

### Installing with tModLoader

1. Make sure you have **Terraria** and **tModLoader 1.4.5** installed.
2. Download the latest release of Guide's Advice.
3. Open tModLoader.
4. From the main menu, select **Workshop → Manage Mods**.
5. Select **Open Mods Folder**.
6. Place the Guide's Advice `.tmod` file in that folder.
7. Return to tModLoader, enable **Guide's Advice** in the Mods menu, and reload mods if prompted.

Once loaded, speak with the vanilla Guide to access the new interactions.

Guide's Advice is built specifically for tModLoader and cannot run on vanilla Terraria by itself. **You must have tModLoader installed to use this mod.**

## Current Features

- Preserves the Guide's original randomized opening dialogue, with occasional stage-appropriate custom small-talk lines.
- Adds **What's Next?**, which identifies the next major progression objective and provides practical instructions for summoning and starting the encounter.
- Incorporates housing advice into **What's Next?** until the Guide has a home. The vanilla Housing button is disabled.
- Changes **What's Next?** to **What Helps?** after its first use, providing concise, boss-specific fight advice.
- Replaces the vanilla Guide Tip interaction with a custom **Hint** interaction.
- Provides randomized hints appropriate to the player's current progression stage.
- Tracks shown hint IDs per character and cycles through applicable hints before repeating.
- Preserves the vanilla Guide crafting interaction.

## Adding Hints

Hints are organized by progression stage under `Progression/Hints/`.

To add a hint:

1. Open the matching stage file, such as `EarlyPreHardmodeHints.cs`.
2. Add another `new HintDefinition("unique.id", "Hint text.")` entry to its `All` list.
3. If the hint should only appear after a condition is met, provide a third argument containing a condition lambda.

Use a unique ID for every hint. Existing IDs are saved in each character's data to prevent repeats.

## Development Notes

- This is an ongoing prototype. Features and progression advice may change as development continues.
- The progress bar is intentionally not implemented. Its intended placement is inside the vanilla Guide conversation panel, above the dialogue text. A separate screen overlay would not meet that requirement, so no external HUD has been added.
- The source archive intentionally excludes `.git`, `obj`, and `bin`. Keep your existing local `.git` directory when copying these source files into your tModLoader `ModSources` folder.
