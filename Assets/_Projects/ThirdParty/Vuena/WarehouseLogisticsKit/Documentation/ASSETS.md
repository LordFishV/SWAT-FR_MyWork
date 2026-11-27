# Warehouse & Logistics Kit - asset list (v1.0)

187 assets: 92 new, 95 reused from the Factory Simulator Kit (rebuilt from its generator code under `wk_` names).
File names are `wk_*` (GLB / FBX / Godot). The Unreal edition will use `SM_` + the name without `wk_` (the same rule as our Store kit UE pack).

## Counts by category

| Category | Assets | New | From Factory kit |
|---|---|---|---|
| Racking | 17 | 14 | 3 |
| Loads | 28 | 9 | 19 |
| Handling | 15 | 6 | 9 |
| Dock | 14 | 14 | 0 |
| Mezzanine | 7 | 6 | 1 |
| Packing | 13 | 10 | 3 |
| Conveyors | 13 | 0 | 13 |
| Office | 13 | 8 | 5 |
| Safety | 40 | 20 | 20 |
| Building | 27 | 5 | 22 |
| **Total** | **187** | **92** | **95** |

Triangles: 252,576 in total (largest: wk_forklift 14,564, wk_reach_truck 12,748, wk_pallet_wrapped_crates 10,928).

## Racking

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_cantilever_rack | wk_cantilever_rack | 3.00 x 1.12 x 2.50 | 924 | F | fk_cantilever_rack |  |
| SM_longspan_shelving | wk_longspan_shelving | 2.02 x 0.62 x 2.40 | 2648 | F | new | hand-pick long-span shelving 2.0 x 0.6 x 2.4, 4 chipboard decks |
| SM_parts_bin_wall | wk_parts_bin_wall | 1.00 x 0.20 x 1.00 | 1520 | M | fk_parts_bin_wall |  |
| SM_rack_back_mesh_2700 | wk_rack_back_mesh_2700 | 2.75 x 0.02 x 5.65 | 672 | O | new | anti-collapse back mesh for one bay, 6 m; origin as the bay |
| SM_rack_bay_6m_add | wk_rack_bay_6m_add | 2.81 x 1.14 x 6.01 | 4188 | O | new | add-on bay: right upright + 3 beam levels; origin = the shared (left) upright centre on the floor |
| SM_rack_bay_6m_start | wk_rack_bay_6m_start | 2.92 x 1.14 x 6.01 | 6828 | O | new | two uprights + 3 beam levels; origin = left upright centre on the floor; next bay at x + 2.79 |
| SM_rack_beam_2700 | wk_rack_beam_2700 | 2.70 x 1.11 x 0.21 | 516 | O | new | front + back beam pair; origin = centre of the left upright at beam-top level (place at upright x, 0, level) |
| SM_rack_deck_2700 | wk_rack_deck_2700 | 2.68 x 1.10 x 0.04 | 432 | O | new | three wire-mesh decks for one level; origin as the beams |
| SM_rack_end_barrier | wk_rack_end_barrier | 0.22 x 1.36 x 0.42 | 840 | O | new | end-of-row frame guard; origin = centre of the protected frame on the floor (guard stands at x -0.29) |
| SM_rack_row_spacer | wk_rack_row_spacer | 0.09 x 0.30 x 2.10 | 264 | O | new | back-to-back row spacer pair (0.30 flue); origin = centre of the left frame column on the floor |
| SM_rack_upright_6m | wk_rack_upright_6m | 0.13 x 1.14 x 6.01 | 2640 | O | new | origin = centre of the frame on the floor; frame depth along Y (1.10), upright section 0.09 along X |
| SM_shelving_unit | wk_shelving_unit | 1.20 x 0.50 x 2.00 | 596 | FB | fk_shelving_unit |  |
| SM_sign_aisle_a | wk_sign_aisle_a | 0.10 x 1.11 x 0.77 | 264 | O | new | aisle sign on a bracket; origin = top of the upright it clamps to (front face) |
| SM_sign_aisle_b | wk_sign_aisle_b | 0.10 x 1.11 x 0.77 | 264 | O | new | as aisle A, printed B |
| SM_sign_aisle_c | wk_sign_aisle_c | 0.10 x 1.11 x 0.77 | 264 | O | new | as aisle A, printed C |
| SM_sign_aisle_d | wk_sign_aisle_d | 0.10 x 1.11 x 0.77 | 264 | O | new | as aisle A, printed D |
| SM_sign_rack_load | wk_sign_rack_load | 0.30 x 0.00 x 0.40 | 44 | M | new | rack load notice plate |

## Loads

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_barrel_plastic | wk_barrel_plastic | 0.58 x 0.58 x 0.94 | 1184 | F | fk_barrel_plastic |  |
| SM_barrel_steel | wk_barrel_steel | 0.60 x 0.60 x 0.88 | 1240 | F | fk_barrel_steel |  |
| SM_box_closed | wk_box_closed | 0.60 x 0.40 x 0.40 | 156 | F | fk_box_closed |  |
| SM_box_flat | wk_box_flat | 1.00 x 0.80 x 0.01 | 156 | F | fk_box_flat |  |
| SM_box_large | wk_box_large | 0.80 x 0.60 x 0.60 | 156 | F | fk_box_large |  |
| SM_box_open | wk_box_open | 0.96 x 0.76 x 0.40 | 120 | F | fk_box_open | moving: flap_1, flap_2, flap_3, flap_4 |
| SM_box_small | wk_box_small | 0.40 x 0.30 x 0.25 | 156 | F | fk_box_small |  |
| SM_bulk_bag | wk_bulk_bag | 0.98 x 0.98 x 1.15 | 2212 | F | fk_bulk_bag |  |
| SM_crate_plastic | wk_crate_plastic | 0.61 x 0.41 x 0.32 | 1012 | F | fk_crate_plastic |  |
| SM_crate_wood | wk_crate_wood | 1.00 x 0.60 x 0.62 | 1056 | F | fk_crate_wood | moving: lid |
| SM_crate_wood_large | wk_crate_wood_large | 1.20 x 0.80 x 0.82 | 1320 | F | fk_crate_wood_large | moving: lid |
| SM_ibc_tank | wk_ibc_tank | 1.20 x 1.10 x 1.16 | 2492 | F | fk_ibc_tank |  |
| SM_pallet_drums_banded | wk_pallet_drums_banded | 1.20 x 1.20 x 1.02 | 6792 | F | new | 4 drums banded on a pallet |
| SM_pallet_load | wk_pallet_load | 1.21 x 0.81 x 1.04 | 2956 | F | fk_pallet_load |  |
| SM_pallet_plastic | wk_pallet_plastic | 1.20 x 0.80 x 0.15 | 1284 | F | fk_pallet_plastic |  |
| SM_pallet_stack_empty | wk_pallet_stack_empty | 1.22 x 0.81 x 1.16 | 7040 | F | new | stack of 8 empty Euro pallets |
| SM_pallet_strapped_cartons | wk_pallet_strapped_cartons | 1.21 x 0.81 x 1.05 | 2796 | F | new | cartons with corner boards and PET straps (no film) |
| SM_pallet_wood | wk_pallet_wood | 1.20 x 0.80 x 0.14 | 880 | F | fk_pallet_wood |  |
| SM_pallet_wrapped_crates | wk_pallet_wrapped_crates | 1.22 x 0.82 x 1.11 | 10928 | F | new | stacked plastic crates, stretch film |
| SM_pallet_wrapped_full | wk_pallet_wrapped_full | 1.21 x 0.81 x 1.34 | 2720 | F | new | Euro pallet, 4 layers of cartons, stretch film (1.34 m) |
| SM_pallet_wrapped_half | wk_pallet_wrapped_half | 1.21 x 0.81 x 0.75 | 1832 | F | new | Euro pallet, 2 layers of cartons, stretch film |
| SM_pallet_wrapped_mixed | wk_pallet_wrapped_mixed | 1.21 x 0.81 x 1.11 | 2420 | F | new | mixed carton sizes, uneven top, stretch film |
| SM_pallet_wrapped_sacks | wk_pallet_wrapped_sacks | 1.22 x 0.82 x 1.01 | 10892 | F | new | 5 layers of woven sacks, stretch film |
| SM_parcel_box | wk_parcel_box | 0.30 x 0.20 x 0.20 | 68 | F | fk_item_box |  |
| SM_sack | wk_sack | 0.52 x 0.38 x 0.19 | 980 | F | fk_item_sack |  |
| SM_spill_pallet | wk_spill_pallet | 1.30 x 0.81 x 0.30 | 292 | F | fk_spill_pallet |  |
| SM_tote | wk_tote | 0.41 x 0.31 x 0.15 | 248 | F | fk_item_tote |  |
| SM_tote_lidded | wk_tote_lidded | 0.60 x 0.41 x 0.35 | 1052 | F | new | attached-lid container 0.60 x 0.40; nodes lid_l, lid_r; moving: lid_l, lid_r |

## Handling

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_battery_charger | wk_battery_charger | 0.55 x 0.25 x 1.00 | 1104 | M | new | wall-mounted truck battery charger with lead |
| SM_cage_trolley | wk_cage_trolley | 0.72 x 0.80 x 1.80 | 2012 | F | new | roll cage with two front half gates; nodes gate_l, gate_r; moving: gate_l, gate_r |
| SM_cage_trolley_loaded | wk_cage_trolley_loaded | 0.72 x 0.80 x 1.80 | 3284 | F | new | roll cage loaded with cartons, gates closed; moving: gate_l, gate_r |
| SM_drum_trolley | wk_drum_trolley | 0.63 x 0.55 x 1.41 | 1716 | F | fk_drum_trolley | moving: wheel_L, wheel_R |
| SM_forklift | wk_forklift | 1.04 x 3.51 x 2.25 | 14564 | F | fk_forklift | moving: wheel_front_L, steer_L, wheel_rear_L, wheel_front_R, steer_R, wheel_rear_R, steering_wheel, mast, mast_inner, carriage |
| SM_hand_truck | wk_hand_truck | 0.60 x 0.53 x 1.22 | 1428 | F | fk_hand_truck | moving: wheel_L, wheel_R |
| SM_ladder_a_frame | wk_ladder_a_frame | 0.50 x 0.96 x 1.75 | 672 | F | fk_ladder_a_frame |  |
| SM_pallet_jack | wk_pallet_jack | 0.54 x 1.69 x 1.23 | 2496 | F | fk_pallet_jack | moving: forks, wheel_L, wheel_R, handle |
| SM_pallet_truck_electric | wk_pallet_truck_electric | 0.72 x 1.91 x 1.29 | 4312 | F | new | walkie electric pallet truck; node tiller (hinge x); moving: tiller |
| SM_picking_cart | wk_picking_cart | 1.00 x 0.56 x 1.02 | 5096 | F | new | two-level picking cart with 4 totes |
| SM_platform_trolley | wk_platform_trolley | 0.90 x 0.60 x 0.97 | 1016 | F | fk_platform_trolley |  |
| SM_reach_truck | wk_reach_truck | 1.30 x 2.88 x 2.72 | 12748 | F | new | reach truck; nodes reach (slide y), mast_inner, carriage (slide z), steer; moving: steer, reach, mast_inner, carriage |
| SM_roll_container | wk_roll_container | 0.74 x 0.82 x 1.71 | 732 | F | fk_roll_container |  |
| SM_scissor_lift_table | wk_scissor_lift_table | 1.37 x 0.82 x 0.97 | 532 | F | fk_scissor_lift_table | moving: platform |
| SM_step_ladder | wk_step_ladder | 0.62 x 1.15 x 1.62 | 2128 | F | fk_step_ladder |  |

## Dock

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_dock_bumper | wk_dock_bumper | 0.30 x 0.13 x 0.50 | 1456 | M | new | laminated rubber dock bumper on steel angles |
| SM_dock_control_box | wk_dock_control_box | 0.30 x 0.18 x 0.65 | 688 | M | new | door and leveler control box |
| SM_dock_door_sectional | wk_dock_door_sectional | 3.70 x 0.34 x 6.50 | 6664 | WS | new | insulated sectional door + vertical-lift tracks; same transform as the opening wall; node door (slide z 3.0); moving: door |
| SM_dock_leveler | wk_dock_leveler | 3.00 x 2.18 x 0.62 | 812 | O | new | hydraulic leveler 2.0 x 2.0 in a pit, top at 0; origin = dock edge centre (pit towards -Y); node lip (hinge x); moving: lip |
| SM_dock_light_arm | wk_dock_light_arm | 0.18 x 1.04 x 0.27 | 628 | M | new | swing-arm dock lamp; node arm (hinge z); moving: arm |
| SM_dock_shelter | wk_dock_shelter | 4.24 x 0.47 x 3.60 | 5388 | M | new | foam pad dock shelter for a 3.0 x 3.0 opening (outside face) |
| SM_dock_signal_light | wk_dock_signal_light | 0.20 x 0.20 x 0.42 | 588 | M | new | red / green dock traffic light |
| SM_dock_wheel_chock | wk_dock_wheel_chock | 0.24 x 0.43 x 0.25 | 156 | F | new | steel wheel chock |
| SM_light_flood_wall | wk_light_flood_wall | 0.42 x 0.52 x 0.30 | 484 | M | new | LED loading-bay floodlight on a wall bracket |
| SM_sign_dock_01 | wk_sign_dock_01 | 0.65 x 0.00 x 0.40 | 44 | M | new | dock number plate |
| SM_sign_dock_02 | wk_sign_dock_02 | 0.65 x 0.00 x 0.40 | 44 | M | new | dock number plate |
| SM_sign_dock_03 | wk_sign_dock_03 | 0.65 x 0.00 x 0.40 | 44 | M | new | dock number plate |
| SM_sign_dock_04 | wk_sign_dock_04 | 0.65 x 0.00 x 0.40 | 44 | M | new | dock number plate |
| SM_wall_dock_opening_4m | wk_wall_dock_opening_4m | 4.00 x 0.16 x 3.20 | 368 | O | new | block wall 4.0 x 0.15 x 3.2 with a 3.0 x 3.0 dock opening; origin = min corner of the wall body (same grid as the wall modules), edge angles stand 6 mm proud |

## Mezzanine

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_mezz_column_3m | wk_mezz_column_3m | 0.30 x 0.30 x 2.72 | 308 | F | new | SHS column with base and cap plate (2.722 tall, the deck beams sit on the cap) |
| SM_mezz_deck_3x3 | wk_mezz_deck_3x3 | 3.00 x 3.00 x 0.28 | 1348 | O | new | deck module 3 x 3, top at 3.00; origin = floor point under the min corner |
| SM_mezz_gate | wk_mezz_gate | 0.96 x 0.06 x 0.99 | 428 | O | new | self-closing swing gate for a 1.0 m railing gap; node gate (hinge z); origin = hinge-side end of the rail line, base at 0; moving: gate |
| SM_mezz_railing_1m | wk_mezz_railing_1m | 1.00 x 0.04 x 1.10 | 188 | O | new | as the 3 m railing, 1.0 m (fills the gap next to the gate or the stairs) |
| SM_mezz_railing_3m | wk_mezz_railing_3m | 3.00 x 0.04 x 1.10 | 276 | O | new | handrail + knee rail + kick plate; rail line on the X axis from 0 to 3, base at 0 |
| SM_mezz_stairs_3m | wk_mezz_stairs_3m | 0.99 x 3.52 x 3.84 | 2288 | O | new | 15 risers x 0.20; origin = floor, centre of the foot; climbs +Y, deck edge at y 3.50 |
| SM_railing_2m | wk_railing_2m | 2.00 x 0.10 x 1.10 | 276 | G | fk_railing_2m |  |

## Packing

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_carton_flat_stack | wk_carton_flat_stack | 1.03 x 0.81 x 0.19 | 360 | F | new | stack of flat-packed cartons |
| SM_kraft_roll_stand | wk_kraft_roll_stand | 0.98 x 0.60 x 0.93 | 716 | F | new | floor stand with a 750 mm kraft paper roll |
| SM_label_applicator | wk_label_applicator | 0.60 x 0.47 x 1.30 | 524 | CV | fk_label_printer |  |
| SM_label_printer_desk | wk_label_printer_desk | 0.20 x 0.33 x 0.17 | 1092 | F | new | desktop shipping-label printer |
| SM_pack_monitor | wk_pack_monitor | 0.55 x 0.20 x 0.46 | 640 | F | new | packing-station monitor on a stand |
| SM_packing_bench | wk_packing_bench | 2.00 x 0.80 x 2.00 | 1468 | F | new | packing bench 2.0 x 0.8 with upper shelf, kraft roll and task light |
| SM_packing_scale | wk_packing_scale | 0.40 x 0.34 x 0.44 | 844 | F | new | parcel scale with display |
| SM_pallet_wrapper | wk_pallet_wrapper | 1.70 x 2.47 x 2.66 | 3304 | F | fk_pallet_wrapper | moving: turntable, film_carriage |
| SM_scanner_gate | wk_scanner_gate | 0.40 x 1.06 x 1.42 | 568 | CV | fk_scanner_gate |  |
| SM_scanner_handheld | wk_scanner_handheld | 0.10 x 0.15 x 0.21 | 1444 | F | new | handheld barcode scanner in its cradle |
| SM_strapping_cart | wk_strapping_cart | 0.73 x 0.67 x 1.01 | 2552 | F | new | PET strapping coil cart with tool tray |
| SM_stretch_film_roll | wk_stretch_film_roll | 0.50 x 0.12 x 0.12 | 440 | F | new | hand stretch-film roll lying on its side |
| SM_tape_gun | wk_tape_gun | 0.19 x 0.27 x 0.07 | 1192 | F | new | hand tape dispenser with tape roll |

## Conveyors

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_conveyor_belt_1m | wk_conveyor_belt_1m | 1.00 x 0.71 x 0.18 | 820 | CV | fk_conveyor_belt_1m |  |
| SM_conveyor_belt_2m | wk_conveyor_belt_2m | 2.04 x 1.03 x 0.21 | 1292 | CV | fk_conveyor_belt_2m |  |
| SM_conveyor_belt_wide_2m | wk_conveyor_belt_wide_2m | 2.04 x 1.33 x 0.21 | 1196 | CV | fk_conveyor_belt_wide_2m |  |
| SM_conveyor_curve_L | wk_conveyor_curve_L | 1.36 x 1.36 x 0.18 | 1980 | CV | fk_conveyor_curve_L |  |
| SM_conveyor_curve_R | wk_conveyor_curve_R | 1.36 x 1.36 x 0.18 | 1980 | CV | fk_conveyor_curve_R |  |
| SM_conveyor_end | wk_conveyor_end | 0.50 x 0.78 x 0.36 | 1304 | CV | fk_conveyor_end |  |
| SM_conveyor_legs | wk_conveyor_legs | 0.18 x 0.76 x 0.66 | 476 | F | fk_conveyor_legs |  |
| SM_conveyor_legs_tall | wk_conveyor_legs_tall | 0.18 x 0.76 x 1.16 | 476 | F | fk_conveyor_legs_tall |  |
| SM_conveyor_roller_1m | wk_conveyor_roller_1m | 1.00 x 0.71 x 0.18 | 1196 | CV | fk_conveyor_roller_1m |  |
| SM_conveyor_roller_2m | wk_conveyor_roller_2m | 2.00 x 0.71 x 0.18 | 2084 | CV | fk_conveyor_roller_2m |  |
| SM_conveyor_roller_curve_L | wk_conveyor_roller_curve_L | 1.35 x 1.35 x 0.18 | 1928 | CV | fk_conveyor_roller_curve_L |  |
| SM_conveyor_splitter | wk_conveyor_splitter | 2.04 x 1.67 x 0.29 | 2244 | CV | fk_conveyor_splitter | moving: diverter |
| SM_conveyor_turntable | wk_conveyor_turntable | 1.00 x 1.00 x 0.82 | 1036 | CV | fk_conveyor_turntable | moving: table |

## Office

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_cabin_steps | wk_cabin_steps | 0.96 x 0.62 x 1.37 | 448 | F | new | two-step metal platform for the cabin door |
| SM_desk_monitor | wk_desk_monitor | 0.61 x 0.40 x 0.43 | 4684 | F | new | monitor + keyboard + mouse set |
| SM_filing_cabinet | wk_filing_cabinet | 0.47 x 0.65 x 1.32 | 1164 | F | new | 4-drawer filing cabinet; nodes drawer_1..4 (slide y); moving: drawer_1, drawer_2, drawer_3, drawer_4 |
| SM_locker_bank | wk_locker_bank | 0.90 x 0.54 x 1.80 | 1944 | FB | fk_locker_bank | moving: door_1, door_2, door_3 |
| SM_office_cabin | wk_office_cabin | 6.26 x 2.60 x 2.70 | 3272 | F | new | in-warehouse office cabin 6.0 x 2.5 x 2.7; node door (hinge z); moving: door |
| SM_office_chair | wk_office_chair | 0.64 x 0.60 x 1.02 | 3672 | F | new | task chair; node seat (rot z); moving: seat |
| SM_office_desk | wk_office_desk | 1.40 x 0.70 x 0.74 | 572 | F | new | steel-frame desk 1.4 x 0.7 |
| SM_tool_chest | wk_tool_chest | 0.75 x 0.49 x 1.40 | 1952 | F | fk_tool_chest | moving: drawer_1, drawer_2, drawer_3, drawer_4, drawer_5, drawer_6, lid |
| SM_toolbox | wk_toolbox | 0.50 x 0.23 x 0.25 | 340 | F | fk_toolbox | moving: lid |
| SM_wall_clock | wk_wall_clock | 0.30 x 0.04 x 0.30 | 952 | M | new | wall clock 0.3 m |
| SM_wheelie_bin | wk_wheelie_bin | 0.62 x 0.84 x 1.06 | 1416 | F | fk_wheelie_bin | moving: wheel_L, wheel_R, lid |
| SM_whiteboard | wk_whiteboard | 1.20 x 0.07 x 0.90 | 360 | M | new | shift whiteboard 1.2 x 0.9 |
| SM_workbench | wk_workbench | 2.00 x 0.96 x 1.04 | 1464 | F | fk_workbench | moving: drawer, vise_jaw |

## Safety

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_barrier_impact_2m | wk_barrier_impact_2m | 2.00 x 0.30 x 0.77 | 840 | G | new | double-rail forklift impact barrier, 2 m |
| SM_barrier_pedestrian_2m | wk_barrier_pedestrian_2m | 2.00 x 0.12 x 1.11 | 708 | G | new | yellow pedestrian guard rail, 2 m |
| SM_barrier_pedestrian_gate | wk_barrier_pedestrian_gate | 1.20 x 0.12 x 1.11 | 820 | G | new | self-closing pedestrian gate; node gate (hinge z); moving: gate |
| SM_barrier_post | wk_barrier_post | 0.34 x 0.34 x 1.03 | 368 | F | fk_barrier_post |  |
| SM_bollard | wk_bollard | 0.20 x 0.20 x 0.98 | 728 | F | fk_bollard |  |
| SM_bollard_heavy | wk_bollard_heavy | 0.40 x 0.40 x 1.25 | 1004 | F | new | concrete-filled steel bollard 0.27 m |
| SM_column_guard | wk_column_guard | 0.54 x 0.56 x 1.00 | 3392 | F | new | wrap-around column guard for 0.3 m columns |
| SM_fire_extinguisher | wk_fire_extinguisher | 0.30 x 0.21 x 0.59 | 1156 | F | fk_fire_extinguisher |  |
| SM_fire_extinguisher_stand | wk_fire_extinguisher_stand | 0.64 x 0.32 x 1.15 | 2156 | F | new | stand with two extinguishers and sign |
| SM_fire_hose_reel | wk_fire_hose_reel | 0.60 x 0.24 x 0.94 | 8968 | M | new | wall hose reel with cabinet sign |
| SM_first_aid_box | wk_first_aid_box | 0.40 x 0.15 x 0.30 | 272 | M | fk_first_aid_box | moving: door |
| SM_mark_arrow | wk_mark_arrow | 1.00 x 0.40 x 0.00 | 24 | F | fk_mark_arrow |  |
| SM_mark_crossing_2x4 | wk_mark_crossing_2x4 | 2.00 x 4.00 x 0.00 | 60 | G | new | pedestrian zebra crossing 2 x 4, 2 mm |
| SM_mark_dashed_2m | wk_mark_dashed_2m | 1.50 x 0.10 x 0.00 | 24 | G | new | dashed yellow lane line, 2 mm slab |
| SM_mark_forklift_symbol | wk_mark_forklift_symbol | 1.00 x 1.00 x 0.00 | 2 | O | new | origin = min corner on the floor, the stencil face lies 2 mm up (no slab under it); forklift floor stencil 1 x 1, 2 mm |
| SM_mark_hazard_2m | wk_mark_hazard_2m | 2.00 x 0.15 x 0.00 | 12 | G | fk_mark_hazard_2m |  |
| SM_mark_keep_clear_2x2 | wk_mark_keep_clear_2x2 | 2.00 x 2.00 x 0.00 | 2 | O | new | origin = min corner on the floor, the stencil face lies 2 mm up (no slab under it); hatched KEEP CLEAR box, 2 mm |
| SM_mark_line_2m | wk_mark_line_2m | 2.00 x 0.10 x 0.00 | 12 | G | fk_mark_line_2m |  |
| SM_mark_pallet_zone | wk_mark_pallet_zone | 1.40 x 1.00 x 0.00 | 96 | F | fk_mark_pallet_zone |  |
| SM_mark_pedestrian_symbol | wk_mark_pedestrian_symbol | 1.00 x 1.00 x 0.00 | 2 | O | new | origin = min corner on the floor, the stencil face lies 2 mm up (no slab under it); pedestrian floor stencil 1 x 1, 2 mm |
| SM_mark_stop | wk_mark_stop | 2.00 x 0.95 x 0.00 | 14 | G | new | STOP line with stencil, 2 mm |
| SM_mark_walkway_2m | wk_mark_walkway_2m | 2.00 x 1.00 x 0.00 | 84 | G | fk_mark_walkway_2m |  |
| SM_rack_protector | wk_rack_protector | 0.20 x 0.20 x 0.40 | 200 | F | fk_rack_protector |  |
| SM_safety_fence_2m | wk_safety_fence_2m | 2.00 x 0.10 x 2.00 | 452 | G | fk_safety_fence_2m |  |
| SM_sign_authorised | wk_sign_authorised | 0.30 x 0.00 x 0.40 | 44 | M | fk_sign_authorised |  |
| SM_sign_exit | wk_sign_exit | 0.40 x 0.00 x 0.20 | 44 | M | fk_sign_exit |  |
| SM_sign_fire | wk_sign_fire | 0.30 x 0.00 x 0.40 | 44 | M | fk_sign_fire |  |
| SM_sign_first_aid | wk_sign_first_aid | 0.30 x 0.00 x 0.40 | 44 | M | fk_sign_first_aid |  |
| SM_sign_forklift | wk_sign_forklift | 0.30 x 0.00 x 0.40 | 44 | M | fk_sign_forklift |  |
| SM_sign_hivis | wk_sign_hivis | 0.30 x 0.00 x 0.40 | 44 | M | new | sign 0.30 x 0.40 |
| SM_sign_keep_clear | wk_sign_keep_clear | 0.30 x 0.00 x 0.40 | 44 | M | new | sign 0.30 x 0.40 |
| SM_sign_loading_bay | wk_sign_loading_bay | 0.30 x 0.00 x 0.40 | 44 | M | new | sign 0.30 x 0.40 |
| SM_sign_no_pedestrians | wk_sign_no_pedestrians | 0.30 x 0.00 x 0.40 | 44 | M | new | sign 0.30 x 0.40 |
| SM_sign_no_smoking | wk_sign_no_smoking | 0.30 x 0.00 x 0.40 | 44 | M | fk_sign_no_smoking |  |
| SM_sign_pedestrians | wk_sign_pedestrians | 0.30 x 0.00 x 0.40 | 44 | M | new | sign 0.30 x 0.40 |
| SM_sign_ppe | wk_sign_ppe | 0.30 x 0.00 x 0.40 | 44 | M | fk_sign_ppe |  |
| SM_sign_speed_limit | wk_sign_speed_limit | 0.30 x 0.00 x 0.40 | 44 | M | new | sign 0.30 x 0.40 |
| SM_spill_kit_bin | wk_spill_kit_bin | 0.62 x 0.61 x 0.95 | 692 | F | new | wheeled spill-kit bin |
| SM_traffic_barrier_2m | wk_traffic_barrier_2m | 2.00 x 0.30 x 0.45 | 520 | G | fk_traffic_barrier_2m |  |
| SM_traffic_cone | wk_traffic_cone | 0.38 x 0.38 x 0.75 | 472 | F | fk_traffic_cone |  |

## Building

| SM name | File | Size W x D x H (m) | Tris | Pivot | Source | Notes |
|---|---|---|---|---|---|---|
| SM_beam_steel_2m | wk_beam_steel_2m | 2.00 x 0.15 x 0.30 | 204 | O | fk_beam_steel_2m |  |
| SM_beam_steel_4m | wk_beam_steel_4m | 4.00 x 0.15 x 0.30 | 204 | O | fk_beam_steel_4m |  |
| SM_bracket_duct_wall | wk_bracket_duct_wall | 0.08 x 0.66 x 0.30 | 212 | M | fk_bracket_duct_wall |  |
| SM_bracket_tray_wall | wk_bracket_tray_wall | 0.08 x 0.44 x 0.12 | 260 | M | fk_bracket_tray_wall |  |
| SM_cable_tray_2m | wk_cable_tray_2m | 2.00 x 0.30 x 0.08 | 536 | O | fk_cable_tray_2m |  |
| SM_column_steel_6m | wk_column_steel_6m | 0.45 x 0.45 x 6.40 | 504 | F | fk_column_steel_6m |  |
| SM_column_steel_9m | wk_column_steel_9m | 0.50 x 0.50 x 8.90 | 380 | F | new | HEB 300 hall column, 9.10 m to the cap (0.50 roof beams on top, roof deck at 9.60) |
| SM_door_steel | wk_door_steel | 1.20 x 0.22 x 2.30 | 980 | WS | fk_door_steel | moving: door |
| SM_duct_2m | wk_duct_2m | 2.00 x 0.44 x 0.34 | 572 | O | fk_duct_2m |  |
| SM_electrical_cabinet | wk_electrical_cabinet | 0.81 x 0.46 x 2.00 | 1040 | FB | fk_electrical_cabinet | moving: door |
| SM_floor_concrete_2x2 | wk_floor_concrete_2x2 | 2.00 x 2.00 x 0.02 | 12 | G | fk_floor_concrete_2x2 |  |
| SM_floor_concrete_4x4 | wk_floor_concrete_4x4 | 4.00 x 4.00 x 0.02 | 12 | G | fk_floor_concrete_4x4 |  |
| SM_light_highbay | wk_light_highbay | 0.33 x 0.33 x 0.45 | 852 | C | fk_light_highbay |  |
| SM_light_highbay_led | wk_light_highbay_led | 0.33 x 0.33 x 0.36 | 1452 | C | new | round LED high-bay on a hook |
| SM_light_linear | wk_light_linear | 1.20 x 0.34 x 0.56 | 160 | C | fk_light_linear |  |
| SM_roof_beam_5m | wk_roof_beam_5m | 5.00 x 0.22 x 0.51 | 284 | O | new | IPE 500 roof beam segment 5 m; origin = start end, centred, top at 0 (hang under the roof deck) |
| SM_roof_panel_4x4 | wk_roof_panel_4x4 | 4.00 x 4.00 x 0.30 | 84 | O | new | insulated roof sandwich panel 4 x 4 + 2 Z purlins; origin = min corner of the panel underside (purlins hang 0.20 below) |
| SM_roof_skylight_4x4 | wk_roof_skylight_4x4 | 4.00 x 4.00 x 0.67 | 380 | O | new | roof panel with a 3 x 1.5 polycarbonate rooflight; origin as the roof panel |
| SM_wall_block_1m | wk_wall_block_1m | 1.00 x 0.15 x 3.20 | 12 | G | fk_wall_block_1m |  |
| SM_wall_block_2m | wk_wall_block_2m | 2.00 x 0.15 x 3.20 | 12 | G | fk_wall_block_2m |  |
| SM_wall_block_doorway_2m | wk_wall_block_doorway_2m | 2.00 x 0.15 x 3.20 | 32 | G | fk_wall_block_doorway_2m |  |
| SM_wall_block_window_2m | wk_wall_block_window_2m | 2.00 x 0.15 x 3.20 | 328 | G | fk_wall_block_window_2m |  |
| SM_wall_clad_1m | wk_wall_clad_1m | 1.00 x 0.15 x 3.20 | 12 | G | fk_wall_clad_1m |  |
| SM_wall_clad_2m | wk_wall_clad_2m | 2.00 x 0.15 x 3.20 | 12 | G | fk_wall_clad_2m |  |
| SM_wall_clad_window_2m | wk_wall_clad_window_2m | 2.00 x 0.15 x 3.20 | 328 | G | fk_wall_clad_window_2m |  |
| SM_wall_corner_post | wk_wall_corner_post | 0.15 x 0.15 x 3.20 | 12 | G | fk_wall_corner_post |  |
| SM_wall_shutter_4m | wk_wall_shutter_4m | 4.00 x 0.65 x 6.40 | 684 | O | fk_wall_shutter_4m | moving: shutter |
