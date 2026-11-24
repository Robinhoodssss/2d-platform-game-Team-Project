DARK DUNGEON TILESET - 64x64 PIXEL ART ENVIRONMENT PACK
=======================================================
Thank you for your purchase!

4 colour variants (grey, mossy, crypt, ember). Every variant contains the same full set:

  terrain_stone/      47-tile blob autotile (brick stone, with moss/dust cap), single tiles, 4 interior variants, autotile_mapping.json, Tiled .tsx with a Wang set
  terrain_wood/       the same 47-tile autotile in wooden planks (walkways, scaffolds, bridges)
  terrain_rock/       the same 47-tile autotile in rough cave rock
  background_walls/   12 non-solid back-wall tiles: plain, barred window, drain, pilaster, cracked, alcove, archway, top trim, base trim, skull relief, chain hooks, wood beam
  props/              57 sprites + soft light glow: crates, barrel, chests, skulls, bones, bookshelf, pillar parts, statue, rubble, sack, cobwebs, shackles, stairs, ladder, platforms, plate, lever,
                      table, chair, stool, altar, coffins, hanging cage, weapon rack, cauldron, potions, candelabra, skeletons, coins, scroll, anvil, bucket, key, gem, mug, shield, sword, unlit torch
  animated/           37 animated pieces (sprite sheet + single frames + preview GIF each) and animations.json (frame counts, fps, loop flags); includes interactive objects (chest opening, lever, pressure plate, crumbling platform, trapdoor, arrow trap), hazards (saw blade, fire trap, pendulum axe, stomper), critters (bat, rat, spider), effects (portal, wisp, steam, drain flow, glowing skull eyes) and more
  parallax/           6 layers, 1024x576, each tiles horizontally: sky, far arcade, colonnade, chains, near pillars, fog
  sample_level.tmx    a ready-made Tiled map (30x17) that uses all three terrains and the wall tiles (open it in Tiled; keep the folder structure)
  previews/           (pack root) a full sample scene (1920x1080) for each variant

ANIMATED PIECES
  torch              8 frames @ 10 fps  loop  64x112  - wall torch with animated flame
  brazier            8 frames @ 10 fps  loop  80x122  - standing brazier, three flames
  chain_short        8 frames @ 6 fps  loop  40x47  - hanging chain, swaying
  chain_long         8 frames @ 6 fps  loop  40x91  - long hanging chain, swaying
  banner_skull       8 frames @ 6 fps  loop  72x132  - waving wall banner
  spike_trap         8 frames @ 8 fps  loop  64x76  - floor spike trap cycle: rest, warning, extend, retract
  liquid_pool_slime  8 frames @ 8 fps  loop  64x64  - tileable liquid surface (slime / water / ectoplasm / lava depending on the variant), repeats horizontally
  rune_floor         8 frames @ 8 fps  loop  64x24  - pulsing floor rune
  door_open          6 frames @ 8 fps  one-shot  68x130  - wooden door swinging open (closed -> open)
  portcullis_raise   6 frames @ 8 fps  one-shot  68x130  - gate rising (closed -> open)
  drip               8 frames @ 10 fps  loop  32x96  - stalactite drip: forms, falls, splashes
  candle             6 frames @ 10 fps  loop  32x56  - candle with flickering flame
  saw_blade          8 frames @ 16 fps  loop  64x64  - spinning saw blade, 64x64 (move it along a rail yourself)
  fire_trap          14 frames @ 10 fps  loop  64x112  - floor fire jet cycle: sparks, burst, fade. Damage window is frames 7-10
  pendulum_axe       16 frames @ 14 fps  loop  272x184  - swinging pendulum axe, pivot at the top centre
  stomper            14 frames @ 12 fps  loop  72x200  - spiked ceiling stomper: wait, drop, slam, retract. Damage window is frames 5-8
  cauldron_bubble    10 frames @ 8 fps  loop  72x88  - bubbling cauldron
  candelabra_lit     8 frames @ 10 fps  loop  56x90  - standing candelabra, three flames
  lantern_swing      12 frames @ 8 fps  loop  64x100  - hanging lantern swinging gently
  chest_open         10 frames @ 10 fps  one-shot  80x90  - treasure chest opening: lid lifts, light and coins appear (one-shot, ends open)
  lever_pull         8 frames @ 10 fps  one-shot  56x60  - lever pulled from off to on (one-shot)
  plate_press        6 frames @ 10 fps  one-shot  72x28  - pressure plate pressed with a dust puff (one-shot)
  crumbling_platform 14 frames @ 12 fps  one-shot  104x110  - wooden platform shakes, cracks and breaks apart (one-shot; trigger when stepped on)
  trapdoor_open      10 frames @ 10 fps  one-shot  80x30  - floor trapdoor swinging open (one-shot)
  arrow_trap         14 frames @ 12 fps  loop  200x36  - wall arrow trap: charge, shoot, flying arrow, reset
  bat_fly            8 frames @ 12 fps  loop  52x36  - bat flapping (loop; move it across the screen yourself)
  rat_run            8 frames @ 12 fps  loop  60x26  - rat running to the right (loop; flip for left)
  spider_drop        14 frames @ 10 fps  loop  36x140  - spider on a thread: descends and climbs back
  portal             12 frames @ 10 fps  loop  88x120  - swirling magic portal, 88x120, glowing in the palette colour
  wisp               12 frames @ 8 fps  loop  40x52  - floating soul wisp with a fading trail
  steam_vent         12 frames @ 10 fps  loop  64x112  - floor grate venting steam
  cobweb_sway        10 frames @ 6 fps  loop  58x52  - cobweb swaying in a draught (corner top-left; flip for the other corner)
  coin_spin          8 frames @ 10 fps  loop  28x30  - spinning gold coin
  gem_sparkle        10 frames @ 10 fps  loop  44x44  - gem with a glint that sparkles across it
  skull_eyes_glow    10 frames @ 8 fps  loop  64x64  - 64x64 overlay: pulsing glowing eyes, place over wall_skull_relief at the same position
  chandelier_swing   12 frames @ 8 fps  loop  140x130  - hanging candle chandelier swinging, five flames
  drain_flow         8 frames @ 10 fps  loop  40x110  - liquid streaming out of a wall drain into a pool (slime / water / ectoplasm / lava by palette)

AUTOTILING
  All three terrains use the 47-tile "blob" layout. Each tile has an 8-neighbour bitmask:
  N=1 NE=2 E=4 SE=8 S=16 SW=32 W=64 NW=128; a diagonal bit only counts when both adjacent edge bits are set.
  autotile_mapping.json (one per terrain) maps every valid mask to its tile index in terrain_autotile.png.
  Tiled: open <variant>_stone.tsx / _wood.tsx / _rock.tsx; the Wang set (mixed) is already filled in, use the Terrain Brush.
  Godot 4: TileSet with Terrain set "Match Corners and Sides"; autotile_mapping.json lists the 8 neighbour bits of every tile.
  Unity: Rule Tile / Tilemap with the sheet sliced at 64x64 (Grid By Cell Size), Filter Mode Point, Compression None.

NOTES
  - Interior variants share the same surface layout, so they can be mixed freely without visible seams.
  - Pieces meant to repeat (liquid_pool, platform_*_mid, pillar_mid, ladder, parallax layers) tile without seams. Hanging chains, drips, door, portcullis, pendulum axe, lantern and stomper are anchored to the top of their frame on purpose; fire trap, cauldron and candelabra are anchored to the bottom.
  - Hazards are art only: damage windows are noted in animations.json (fire trap frames 7-10, stomper frames 5-8).
  - Tiles are 64x64. Characters around 100-140 px tall (like the creature packs by the same creator) fit at 1:1, roughly two tiles tall.

LICENSE: commercial license - see LICENSE.txt
