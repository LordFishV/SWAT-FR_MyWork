Warehouse & Logistics Simulator Kit v1.0 - Unity package (URP + Built-in) - Read Me
======================================================================

Made by Vuena Studio. 187 FBX models, 187 prefabs, 58 materials, 1 demo scene(s).
Made with our own procedural Blender code (AI-assisted code); no AI-generated meshes or textures.

ENGINE AND RENDER PIPELINE
--------------------------
Built and tested with Unity 6000.3.23f1.
Primary pipeline : Universal Render Pipeline (URP 17, shader "Universal Render Pipeline/Lit"). Materials in Materials/ are URP/Lit.
Built-in pipeline: a nested package is included: BuiltIn/WarehouseLogisticsKit_BuiltIn_Materials.unitypackage (Standard shader, same GUIDs).
                   Import it into a Built-in project and it replaces the URP materials in place.
HDRP: not supported out of the box (use Edit > Rendering > Materials > Convert Selected Built-in Materials to HDRP).
Colour space: Linear (Unity 6 default). Gamma works but looks slightly different.
Older Unity versions: this package was exported from Unity 6000.3.23f1 and has not been tested in other versions.

LINKS
-----
itch.io: https://vuena.itch.io/warehouse-simulator-kit
Fab: listing not public yet (the Fab page is not live at the time of this release; see the itch page).
Support: hello@popyca.com

QUICK START
-----------
1. Open (or create) a URP project (Unity 6, "Universal 3D" template is fine). A project that already has a URP asset assigned in Project Settings > Graphics is required.
2. Assets > Import Package > Custom Package..., pick the .unitypackage, import everything. Everything lands in Assets/Vuena/WarehouseLogisticsKit/.
   The package contains no scripts, project settings or render pipeline assets, so it does not touch your project.
3. Open a demo scene from Assets/Vuena/WarehouseLogisticsKit/Scenes/:
   - Scenes/WarehouseLogisticsKit_Demo_Warehouse.unity
4. Drag any prefab from Prefabs/<Module>/ into your scene. Every FBX in Models/ has a matching prefab.

BUILT-IN PROJECT
----------------
Import the main package, then double-click BuiltIn/WarehouseLogisticsKit_BuiltIn_Materials.unitypackage inside it (or Assets/Vuena/WarehouseLogisticsKit/BuiltIn/...) and import.
Without this step a Built-in project shows the URP materials as pink: that is Unity, not a missing texture.

FOLDERS (Assets/Vuena/WarehouseLogisticsKit)
------------------------------
Models/<Module>/*.fbx   source FBX files (1 unit = 1 metre, Y up, no animation, Read/Write on for the mesh colliders)
Prefabs/<Module>/*.prefab  one prefab per FBX: root at identity, "Model" child holds the FBX hierarchy, colliders already added
Materials/*.mat         URP/Lit materials, named like the material slots of the FBX files
Textures/               colour, normal and emission maps; *_MS.png = metallic (RGB) + smoothness (A) generated from the glTF roughness/metal maps
Colliders/              generated solid-only collision meshes for parts that mix glass/wire with solid parts (only where needed)
Scenes/                 demo scene(s): camera, directional light, skybox, post-processing volume
BuiltIn/                nested package with the Built-in (Standard shader) materials
Documentation/          this file, the original kit README, CHANGELOG, CREDITS, LICENSE, asset list (csv)

COLLIDERS
---------
- Small props (largest side under 0.6 m): one BoxCollider on the root, fitted to the combined mesh bounds (37 prefabs).
- Larger assets (150 prefabs): a non-convex MeshCollider on every mesh node (static or kinematic use only; Unity cannot put a non-convex MeshCollider on a normal Rigidbody).
- Glass, acrylic and alpha-cut parts get a thin BoxCollider instead of a mesh collider.
- Doors, lids, drawers and other moving parts keep their own colliders.
- Nothing is a trigger and nothing has a Rigidbody.

LODS
----
The source kit has no LOD meshes, so the package has none. Triangle counts are in the asset list (Documentation).

NOTES (honest)
--------------
- The prefab root sits on the pivot of the original asset (usually floor level). Move/rotate/scale the prefab ROOT, never the "Model" child:
  the Blender exporter leaves a 270 degree rotation about X on it.
- Moving parts (doors, lids, drawers ...) are separate child objects with their own pivots.
- The demo scene(s) are recreated from the Demo glTF files shipped in the kit (positions and rotations taken from those files). Ceiling and roof pieces are switched off in the scene so the camera can look inside.
- Hanging items (pendant lamps, curtains) keep their place; with the ceilings switched off in the demo they can look as if they float.
- Built-in (Standard shader) materials are one-sided: double-sided parts such as glass or wire show one face only in a Built-in project.
- Emission is set on emissive materials (signs, screens, lamps); add Bloom in a post-processing Volume to make them glow (the demo scene has one).
- Textures keep their original resolution (capped at 2048 on import). Set your platform's texture compression yourself.
- Tested in a clean URP project in Unity 6000.3.23f1: 0 console errors, and a render test that fails on any pink (shader error) material. The nested Built-in package was imported into the same project with the pipeline switched off and rendered without pink as well.

---------------- ORIGINAL KIT README (parts about Blender / Godot / GLB folders do not apply to this Unity package) ----------------

# Warehouse & Logistics Kit - Modular Interior v1.0

187 realistic PBR assets for warehouse, logistics, distribution-centre and simulator games, plus a furnished 30 x 40 m demo warehouse (GLB + Godot 4 scene).
6 m selective pallet racking in modular bays, a loading dock with sectional doors and levelers, a mezzanine with stairs, stretch-wrapped pallet loads,
a reach truck and pallet trucks, a packing station, roll cages, a shift-office cabin, floor markings, barriers and safety signs.
Made by Vuena. 92 assets are new in this kit; 95 come from our Factory Simulator Kit (same style, scale and texel density), regrouped for a warehouse.

## What is inside (187 assets, one file each; file names start with `wk_`)
- Racking (17): cantilever_rack, longspan_shelving, parts_bin_wall, rack_back_mesh_2700, rack_bay_6m_add, rack_bay_6m_start, rack_beam_2700, rack_deck_2700, rack_end_barrier, rack_row_spacer, rack_upright_6m, shelving_unit, sign_aisle_a, sign_aisle_b, sign_aisle_c, sign_aisle_d, sign_rack_load.
- Loads (28): barrel_plastic, barrel_steel, box_closed, box_flat, box_large, box_open, box_small, bulk_bag, crate_plastic, crate_wood, crate_wood_large, ibc_tank, pallet_drums_banded, pallet_load, pallet_plastic, pallet_stack_empty, pallet_strapped_cartons, pallet_wood, pallet_wrapped_crates, pallet_wrapped_full, pallet_wrapped_half, pallet_wrapped_mixed, pallet_wrapped_sacks, parcel_box, sack, spill_pallet, tote, tote_lidded.
- Handling (15): battery_charger, cage_trolley, cage_trolley_loaded, drum_trolley, forklift, hand_truck, ladder_a_frame, pallet_jack, pallet_truck_electric, picking_cart, platform_trolley, reach_truck, roll_container, scissor_lift_table, step_ladder.
- Dock (14): dock_bumper, dock_control_box, dock_door_sectional, dock_leveler, dock_light_arm, dock_shelter, dock_signal_light, dock_wheel_chock, light_flood_wall, sign_dock_01, sign_dock_02, sign_dock_03, sign_dock_04, wall_dock_opening_4m.
- Mezzanine (7): mezz_column_3m, mezz_deck_3x3, mezz_gate, mezz_railing_1m, mezz_railing_3m, mezz_stairs_3m, railing_2m.
- Packing (13): carton_flat_stack, kraft_roll_stand, label_applicator, label_printer_desk, pack_monitor, packing_bench, packing_scale, pallet_wrapper, scanner_gate, scanner_handheld, strapping_cart, stretch_film_roll, tape_gun.
- Conveyors (13): conveyor_belt_1m, conveyor_belt_2m, conveyor_belt_wide_2m, conveyor_curve_L, conveyor_curve_R, conveyor_end, conveyor_legs, conveyor_legs_tall, conveyor_roller_1m, conveyor_roller_2m, conveyor_roller_curve_L, conveyor_splitter, conveyor_turntable.
- Office (13): cabin_steps, desk_monitor, filing_cabinet, locker_bank, office_cabin, office_chair, office_desk, tool_chest, toolbox, wall_clock, wheelie_bin, whiteboard, workbench.
- Safety (40): barrier_impact_2m, barrier_pedestrian_2m, barrier_pedestrian_gate, barrier_post, bollard, bollard_heavy, column_guard, fire_extinguisher, fire_extinguisher_stand, fire_hose_reel, first_aid_box, mark_arrow, mark_crossing_2x4, mark_dashed_2m, mark_forklift_symbol, mark_hazard_2m, mark_keep_clear_2x2, mark_line_2m, mark_pallet_zone, mark_pedestrian_symbol, mark_stop, mark_walkway_2m, rack_protector, safety_fence_2m, sign_authorised, sign_exit, sign_fire, sign_first_aid, sign_forklift, sign_hivis, sign_keep_clear, sign_loading_bay, sign_no_pedestrians, sign_no_smoking, sign_pedestrians, sign_ppe, sign_speed_limit, spill_kit_bin, traffic_barrier_2m, traffic_cone.
- Building (27): beam_steel_2m, beam_steel_4m, bracket_duct_wall, bracket_tray_wall, cable_tray_2m, column_steel_6m, column_steel_9m, door_steel, duct_2m, electrical_cabinet, floor_concrete_2x2, floor_concrete_4x4, light_highbay, light_highbay_led, light_linear, roof_beam_5m, roof_panel_4x4, roof_skylight_4x4, wall_block_1m, wall_block_2m, wall_block_doorway_2m, wall_block_window_2m, wall_clad_1m, wall_clad_2m, wall_clad_window_2m, wall_corner_post, wall_shutter_4m.

33 assets have moving parts as separate child nodes with their own pivot (71 moving nodes):
- wk_barrier_pedestrian_gate: gate (hinge z)
- wk_box_open: flap_1 (hinge x), flap_2 (hinge x), flap_3 (hinge y), flap_4 (hinge y)
- wk_cage_trolley: gate_l (hinge z), gate_r (hinge z)
- wk_cage_trolley_loaded: gate_l (hinge z), gate_r (hinge z)
- wk_conveyor_splitter: diverter (hinge z)
- wk_conveyor_turntable: table (rot z)
- wk_crate_wood: lid (slide z)
- wk_crate_wood_large: lid (slide z)
- wk_dock_door_sectional: door (slide z)
- wk_dock_leveler: lip (hinge x)
- wk_dock_light_arm: arm (hinge z)
- wk_door_steel: door (hinge z)
- wk_drum_trolley: wheel_L (rot x), wheel_R (rot x)
- wk_electrical_cabinet: door (hinge z)
- wk_filing_cabinet: drawer_1 (slide y), drawer_2 (slide y), drawer_3 (slide y), drawer_4 (slide y)
- wk_first_aid_box: door (hinge z)
- wk_forklift: wheel_front_L (rot x), steer_L (rot z), wheel_rear_L (rot x), wheel_front_R (rot x), steer_R (rot z), wheel_rear_R (rot x), steering_wheel (rot z), mast (rot x), mast_inner (slide z), carriage (slide z)
- wk_hand_truck: wheel_L (rot x), wheel_R (rot x)
- wk_locker_bank: door_1 (hinge z), door_2 (hinge z), door_3 (hinge z)
- wk_mezz_gate: gate (hinge z)
- wk_office_cabin: door (hinge z)
- wk_office_chair: seat (rot z)
- wk_pallet_jack: forks (slide z), wheel_L (rot x), wheel_R (rot x), handle (rot x)
- wk_pallet_truck_electric: tiller (hinge x)
- wk_pallet_wrapper: turntable (rot z), film_carriage (slide z)
- wk_reach_truck: steer (rot z), reach (slide y), mast_inner (slide z), carriage (slide z)
- wk_scissor_lift_table: platform (slide z)
- wk_tool_chest: drawer_1 (slide y), drawer_2 (slide y), drawer_3 (slide y), drawer_4 (slide y), drawer_5 (slide y), drawer_6 (slide y), lid (hinge x)
- wk_toolbox: lid (hinge x)
- wk_tote_lidded: lid_l (hinge x), lid_r (hinge x)
- wk_wall_shutter_4m: shutter (scale z)
- wk_wheelie_bin: wheel_L (rot x), wheel_R (rot x), lid (hinge x)
- wk_workbench: drawer (slide y), vise_jaw (slide y)
Axes are local Blender axes (in glTF / Godot, local Z becomes Y and local Y becomes -Z). `assets.csv` lists every asset with its module, pivot, size, triangles and moving parts;
`ASSETS.md` has the same list with the Unreal-style `SM_` names.

## Pallet racking system (6 m)
- Upright frames 1.10 deep, 6.00 high, section 0.09 along the beam; clear beam length 2.70 (three Euro pallets 1.20 x 0.80 on their 0.80 face); upright pitch 2.79.
- Beam tops at 1.60 / 3.20 / 4.80; a 1.35 m loaded pallet fits under each level with lift clearance.
- `wk_rack_bay_6m_start` = two uprights + 3 beam levels (origin = centre of the left upright on the floor). Chain `wk_rack_bay_6m_add` (one upright + beams)
  every 2.79 m along +X. Beams (`wk_rack_beam_2700`) and wire decks (`wk_rack_deck_2700`) also come separately: origin = centre of the left upright at beam-top level.
- Back-to-back rows: 0.30 m flue, `wk_rack_row_spacer` on each frame. `wk_rack_end_barrier` guards the frame at a row end. Front of the bay = -Y (beam location labels).

## Dock, mezzanine, building grid
- Walls are the Factory / Store kit modules: 2.00 x 0.15 x 3.20, room side = -Y; stack three rows for the 9.60 m eaves of the demo. `wk_wall_dock_opening_4m` has a 3.0 x 3.0 opening;
  `wk_dock_door_sectional` uses the same transform (its `door` node slides +Z 3.0 m = open). `wk_dock_leveler`: origin on the outside face of the wall, centred on the
  opening, top flush with the floor; its 2.0 x 2.0 pit replaces one 2 x 2 floor slab (yard 1.20 m below the floor). Shelter, bumpers and floodlight go on the outside face.
- Mezzanine: `wk_mezz_deck_3x3` (origin = floor point under its min corner, deck top 3.00) on `wk_mezz_column_3m` at the module corners; `wk_mezz_stairs_3m`
  (15 x 0.20 risers, needs a 1.0 m gap in the railing); railings 3 m / 1 m and a self-closing gate.
- Roof: `wk_column_steel_9m` (8.90) carries `wk_roof_beam_5m` (0.50 deep) every 5 m; the 4 x 4 roof panels (+ rooflight variant) hang their Z purlins on the beams (deck underside 9.60).
- Floor markings are 2 mm slabs or alpha-clipped stencils: put them on the floor top (z 0 when the floor slabs sit at -0.02, as in the demo).

## Folders
- `GLB/<module>/*.glb`: self-contained (textures embedded). Modules: Racking, Loads, Handling, Dock, Mezzanine, Packing, Conveyors, Office, Safety, Building.
- `FBX/<module>/*.fbx`: textures referenced as `../../Textures/<file>` (keep `Textures/` next to `FBX/`).
- `Textures/`: 47 shared PNG / JPG textures (power of two, max 2048). `Textures/Editable/`: UV guides of the two warehouse atlases (T_WK_Signs, T_WK_Plates).
- `Demo/wk_demo_warehouse.glb`: the furnished demo warehouse (1392 placed objects, built only from kit files; one dock door open, reach truck lifting a pallet).
- `Godot/`: Godot 4 project, `scenes/warehouse_demo.tscn` (same layout, moving parts in their rest pose). Generated and file-checked; NOT opened in the Godot editor.
- `Previews/`: demo screenshots (day and night shift), contact sheets.

## Conventions (same as our Store, Factory and Apartment kits)
- 1 unit = 1 m, real-world scale. Z up in Blender, Y up in glTF / Godot. Front = -Y in Blender (+Z in glTF). Root scale 1, rotation 0, transforms applied.
- Pivots: F = bottom centre; FB = against a wall (back face on y = 0); M = wall-mounted (back on y = 0, bottom at z = 0); C = ceiling-hung (top at z = 0);
  G = grid module, min corner at the origin; WS = same transform as its wall module; CV = conveyor piece (floor under the entry end, travel +X); O = origin stated per asset in assets.csv.
- Materials: Principled BSDF / glTF metal-roughness. Base colour sRGB, normal maps OpenGL (Y+), roughness / metal packed glTF-style (G / B) in `*_MR` maps.
  Stretch film is alpha-blended; wire decks, mesh panels, gratings and floor stencils are alpha-masked.

## Notes (honest)
- Checked by the Khronos glTF validator (0 errors, 0 warnings on every GLB), our scripted checks (scale, pivots, UVs, triangles, textures, materials, brand scan,
  mirrored text, detached parts) and a Blender 4.5 re-import of every FBX. The demo scene was checked for floating objects and mesh intersections.
- FBX files carry base colour, normal and emission maps; the packed roughness / metal maps (`*_MR`) are not carried by Blender's FBX exporter: plug them in by hand (GLB has everything).
- No people, no baked animation clips (moving parts are pivoted child nodes), no colliders, no LODs, no real brands. Signs use generic words only.
- Variants, labelled honestly: the four aisle signs and four dock numbers share one plate each with different prints; wrapped pallet loads share the pallet and cartons
  in different stacks; railings 3 m / 1 m. There are no pure colour swaps.
- Third-party content: four CC0 Poly Haven textures (see CREDITS.txt).

