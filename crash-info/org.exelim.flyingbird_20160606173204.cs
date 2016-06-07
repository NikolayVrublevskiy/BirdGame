S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20150902.2338
Build-Date: 2015.09.02 23:38:00

Crash Information
Process Name: flyingbird
PID: 9006
Date: 2016-06-06 17:32:04+0900
Executable File Path: /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xbfc65b60
ebp = 0xbfc65a98, esp = 0xbfc65a94
eax = 0x00000038, ebx = 0xb401a808
ecx = 0x00000038, edx = 0x00000000
eip = 0xb400588d

Memory Information
MemTotal:      124 KB
MemFree:        57 KB
Buffers:         6 KB
Cached:     144820 KB
VmPeak:      67028 KB
VmSize:      67028 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15676 KB
VmRSS:       15676 KB
VmData:       6184 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32432 KB
VmPTE:          56 KB
VmSwap:          0 KB

Maps Information
b3bc1000 b3be5000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b3d4e000 b3d51000 r-xp /usr/lib/libdri2.so.0.0.0
b3d52000 b3d5b000 r-xp /usr/lib/libtbm.so.1.0.0
b3d60000 b3d6e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3d6f000 b3d7a000 r-xp /usr/lib/libdrm.so.2.4.0
b3d7b000 b3d94000 r-xp /usr/lib/yagl/libEGL.so.1.0
b3d95000 b3ddd000 r-xp /usr/lib/yagl/libGLESv2.so.2.0
b3de0000 b3e6a000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so
b3e74000 b3e77000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3e78000 b3fbc000 r-xp /usr/lib/libcairo.so.2.11200.14
b3fc0000 b3fe1000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3fe2000 b401a000 r-xp /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
b401b000 b4026000 r-xp /lib/libnss_files-2.13.so
b4385000 b43ac000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b43ad000 b43d2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b43d3000 b44f3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4503000 b4539000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b453b000 b453e000 r-xp /usr/lib/libiniparser.so.0
b4540000 b454a000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b454b000 b4554000 r-xp /usr/lib/libappsvc.so.0.1.0
b4555000 b4558000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b455b000 b4563000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4564000 b4566000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4567000 b456d000 r-xp /usr/lib/libogg.so.0.7.1
b456e000 b4599000 r-xp /usr/lib/libvorbis.so.0.4.3
b459a000 b4685000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4693000 b4695000 r-xp /usr/lib/libXau.so.6.0.0
b4696000 b46f6000 r-xp /usr/lib/libssl.so.1.0.0
b46fb000 b472c000 r-xp /usr/lib/libidn.so.11.5.44
b472d000 b473d000 r-xp /usr/lib/libcares.so.2.1.0
b473e000 b47a7000 r-xp /usr/lib/libsndfile.so.1.0.25
b47ad000 b47b7000 r-xp /usr/lib/libsensord-share.so
b47b8000 b47de000 r-xp /lib/libexpat.so.1.5.2
b47e0000 b4807000 r-xp /usr/lib/libpng12.so.0.50.0
b4808000 b4828000 r-xp /usr/lib/libxcb.so.1.1.0
b4829000 b4898000 r-xp /usr/lib/libcurl.so.4.3.0
b489a000 b48a5000 r-xp /usr/lib/libethumb.so.1.7.99
b5e05000 b5edd000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ee9000 b5eec000 r-xp /usr/lib/libctxdata.so.0.0.0
b5eed000 b5f03000 r-xp /usr/lib/libremix.so.0.0.0
b5f04000 b5f06000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f07000 b5f33000 r-xp /usr/lib/liblua-5.1.so
b5f34000 b5f3e000 r-xp /usr/lib/libembryo.so.1.7.99
b5f3f000 b5f85000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f96000 b5fb4000 r-xp /usr/lib/libsensor.so.1.1.0
b5fb6000 b6038000 r-xp /usr/lib/libpixman-1.so.0.28.2
b603d000 b6071000 r-xp /usr/lib/libfontconfig.so.1.5.0
b6073000 b60ce000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b60d0000 b60e6000 r-xp /usr/lib/libfribidi.so.0.3.1
b60e7000 b6173000 r-xp /usr/lib/libfreetype.so.6.11.3
b6177000 b617a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b617b000 b6181000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6182000 b6188000 r-xp /usr/lib/libecore_fb.so.1.7.99
b618a000 b619b000 r-xp /usr/lib/libXext.so.6.4.0
b619c000 b62d0000 r-xp /usr/lib/libX11.so.6.3.0
b62d4000 b62d9000 r-xp /usr/lib/libXtst.so.6.1.0
b62da000 b62e2000 r-xp /usr/lib/libXrender.so.1.3.0
b62e3000 b62ec000 r-xp /usr/lib/libXrandr.so.2.2.0
b62ed000 b62ef000 r-xp /usr/lib/libXinerama.so.1.0.0
b62f0000 b62fe000 r-xp /usr/lib/libXi.so.6.1.0
b62ff000 b6303000 r-xp /usr/lib/libXfixes.so.3.1.0
b6304000 b6306000 r-xp /usr/lib/libXgesture.so.7.0.0
b6307000 b6309000 r-xp /usr/lib/libXcomposite.so.1.0.0
b630a000 b630c000 r-xp /usr/lib/libXdamage.so.1.1.0
b630d000 b6316000 r-xp /usr/lib/libXcursor.so.1.0.2
b6317000 b6342000 r-xp /usr/lib/libecore_con.so.1.7.99
b6344000 b634c000 r-xp /usr/lib/libecore_imf.so.1.7.99
b634d000 b6358000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6359000 b635f000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6360000 b6381000 r-xp /usr/lib/libefreet.so.1.7.99
b6383000 b638f000 r-xp /usr/lib/libedbus.so.1.7.99
b6390000 b64ef000 r-xp /usr/lib/libicuuc.so.51.1
b64fd000 b6706000 r-xp /usr/lib/libicui18n.so.51.1
b670f000 b67ac000 r-xp /usr/lib/libedje.so.1.7.99
b67ae000 b67bf000 r-xp /usr/lib/libecore_input.so.1.7.99
b67c0000 b67c7000 r-xp /usr/lib/libecore_file.so.1.7.99
b67c8000 b67ee000 r-xp /usr/lib/libeet.so.1.7.99
b67f7000 b691f000 r-xp /usr/lib/libevas.so.1.7.99
b693c000 b696f000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6971000 b69b5000 r-xp /usr/lib/libecore_x.so.1.7.99
b69b7000 b6bb1000 r-xp /usr/lib/libelementary.so.1.7.99
b6bc2000 b6bc8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6bc9000 b6bcd000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bd1000 b6bd2000 r-xp /usr/lib/libjournal.so.0.1.0
b6bd3000 b6d1b000 r-xp /usr/lib/libxml2.so.2.7.8
b6d22000 b6d35000 r-xp /lib/libresolv-2.13.so
b6d39000 b6d56000 r-xp /lib/libz.so.1.2.5
b6d57000 b6d5a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d5b000 b6d60000 r-xp /usr/lib/libffi.so.5.0.10
b6d61000 b6d62000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d64000 b6d68000 r-xp /lib/libattr.so.1.1.0
b6d69000 b6f7b000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f96000 b6fb7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fb8000 b6fe0000 r-xp /lib/libm-2.13.so
b6fe2000 b703d000 r-xp /usr/lib/libeina.so.1.7.99
b7040000 b704b000 r-xp /usr/lib/libvconf.so.0.2.45
b704c000 b704f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7050000 b709e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b709f000 b7200000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7204000 b720b000 r-xp /lib/librt-2.13.so
b720e000 b7215000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7217000 b7231000 r-xp /lib/libgcc_s-4.6.4.so.1
b7232000 b723a000 r-xp /lib/libcrypt-2.13.so
b7263000 b7267000 r-xp /lib/libcap.so.2.21
b7268000 b726a000 r-xp /usr/lib/libiri.so
b726c000 b7298000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7299000 b72b9000 r-xp /usr/lib/libecore.so.1.7.99
b72c8000 b72d1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72d2000 b73f5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73f6000 b7409000 r-xp /usr/lib/libail.so.0.1.0
b740b000 b7430000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7431000 b743b000 r-xp /lib/libunwind.so.8.0.1
b7445000 b75b6000 r-xp /lib/libc-2.13.so
b75bc000 b7606000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7607000 b760c000 r-xp /usr/lib/libbundle.so.0.1.22
b760d000 b7610000 r-xp /lib/libdl-2.13.so
b7613000 b7618000 r-xp /usr/lib/libsmack.so.1.0.0
b7619000 b76c1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76c4000 b76de000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76df000 b76f6000 r-xp /lib/libpthread-2.13.so
b76fa000 b76fd000 r-xp /usr/lib/libdlog.so.0.0.0
b76fe000 b770e000 r-xp /usr/lib/libaul.so.0.1.0
b7710000 b7716000 r-xp /usr/lib/libappcore-common.so.1.1
b7717000 b771c000 r-xp /usr/lib/libappcore-efl.so.1.1
b771e000 b7723000 r-xp /usr/lib/libsys-assert.so
b7726000 b7744000 r-xp /lib/ld-2.13.so
b7744000 b7745000 r-xp [vdso]
b7747000 b774e000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:9006)
Call Stack Count: 22
 0: std::vector<Vector2f, std::allocator<Vector2f> >::size() const + 0xd (0xb400588d) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x2388d
 1: BirdObject::CheckTopPoints(std::shared_ptr<PipeObject>) + 0x4d (0xb40048cd) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x228cd
 2: BirdObject::CheckInteractWithTube(std::shared_ptr<PipeObject>) + 0x94 (0xb40047a4) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x227a4
 3: PipeManager::CheckTubes(std::shared_ptr<BirdObject>, std::shared_ptr<ScoreObject>) + 0x120 (0xb3fed650) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xb650
 4: Game::Draw(double) + 0x1e0 (0xb3fe5ad0) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x3ad0
 5: draw_gl(_Evas_Object*) + 0x12e (0xb400096e) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x1e96e
 6: (0xb6a8d32d) [/usr/lib/libelementary.so.1] + 0xd632d
 7: (0xb3deb42d) [/usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so] + 0xb42d
 8: (0xb68251c1) [/usr/lib/libevas.so.1] + 0x2e1c1
 9: (0xb6872635) [/usr/lib/libevas.so.1] + 0x7b635
10: (0xb6876305) [/usr/lib/libevas.so.1] + 0x7f305
11: (0xb69518d7) [/usr/lib/libecore_evas.so.1] + 0x158d7
12: (0xb694d336) [/usr/lib/libecore_evas.so.1] + 0x11336
13: (0xb72a5852) [/usr/lib/libecore.so.1] + 0xc852
14: (0xb72a7525) [/usr/lib/libecore.so.1] + 0xe525
15: ecore_main_loop_begin + 0x3f (0xb72a79cf) [/usr/lib/libecore.so.1] + 0xe9cf
16: elm_run + 0x17 (0xb6abe867) [/usr/lib/libelementary.so.1] + 0x107867
17: appcore_efl_main + 0x3d1 (0xb7719e91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
18: ui_app_main + 0x130 (0xb6bcb500) [/usr/lib/libcapi-appfw-application.so.0] + 0x2500
19: main + 0x133 (0xb4000073) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x1e073
20: Game::Game() + 0x11 (0xb774a5b1) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xb774a5b1
21: __libc_start_main + 0xf3 (0xb745e0f3) [/lib/libc.so.6] + 0x190f3
End of Call Stack

Package Information
Package Name: org.exelim.flyingbird
Package ID : org.exelim.flyingbird
Version: 1.0.1
Package Type: rpm
App Name: Flying Bird
App ID: org.exelim.flyingbird
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
erkey(518) > [SECURE_LOG] [_launch_home_by_powerkey:518] launch[org.tizen.w-home], pid[2271]
06-06 17:31:55.563+0900 D/W_HOME  ( 2271): util.c: util_find_top_visible_window(344) > Failed to get win info: 1000003
06-06 17:31:55.563+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.573+0900 D/W_HOME  ( 2271): util.c: get_user_created_window(229) > User window: 1c00003 (for 60cc09)
06-06 17:31:55.573+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(259) > Get Command of 1c00003
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(265) > Command[0]: /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[1]: `zaybxcwdveuftgsh`
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[2]: __AUL_SDK__
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[3]: IgAAAAEEAAAMAAAAX19BVUxfU0RLX18ABgAAAERFQlVHAA==
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[4]: DEBUG
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[5]: KAAAAAEEAAAGAAAAREVCVUcAEgAAAF9fRExQX0RFQlVHX0FSR19fAA==
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[6]: __DLP_DEBUG_ARG__
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[7]: KQAAAAEEAAASAAAAX19ETFBfREVCVUdfQVJHX18ABwAAADoyNjEwNAA=
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[8]: __AUL_STARTTIME__
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[9]: NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NjUyMDE4OTEvNDkyMzcwAA==
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[10]: __AUL_CALLER_PID__
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): util.c: get_window_info(272) > Command[11]: KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4OTk1AA==
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): 
06-06 17:31:55.583+0900 D/APPS    ( 2271): apps_main.c: apps_main_is_visible(757) >  bShow:[1]
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): main.c: _app_control(1299) > Powerkey operation
06-06 17:31:55.583+0900 D/APPS    ( 2271): apps_main.c: apps_main_launch(588) >  APPS LAUNCH
06-06 17:31:55.583+0900 D/APPS    ( 2271): apps_main.c: apps_main_launch(605) >  Hide the Apps
06-06 17:31:55.583+0900 D/APPS    ( 2271): apps_main.c: apps_main_launch(607) >  There is a window already
06-06 17:31:55.583+0900 D/APPS    ( 2271): layout.c: apps_layout_show(476) >  (0xb7befd80) Hide the tray
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): main.c: _app_control(1308) > clock is displayed
06-06 17:31:55.583+0900 D/LAUNCH  ( 2271): appcore-efl.c: __do_app(501) > [w-home:Application:reset:done]
06-06 17:31:55.583+0900 I/APP_CORE( 2271): appcore-efl.c: __do_app(514) > Legacy lifecycle: 0
06-06 17:31:55.583+0900 I/APP_CORE( 2271): appcore-efl.c: __do_app(516) > [APP 2271] App already running, raise the window
06-06 17:31:55.583+0900 I/APP_CORE( 2271): appcore-efl.c: __do_app(520) > [APP 2271] Call the resume_cb
06-06 17:31:55.583+0900 I/CAPI_APPFW_APPLICATION( 2271): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): main.c: _resume_cb(564) > Resumed
06-06 17:31:55.583+0900 D/APPS    ( 2271): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
06-06 17:31:55.583+0900 E/efl-extension( 2271): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb7ae7668, elm_scroller, _activated_obj : 0xb7bef650, activated : 1
06-06 17:31:55.583+0900 E/efl-extension( 2271): efl_extension_rotary.c: eext_rotary_object_event_activated_set(309) > Activation delete!!!!
06-06 17:31:55.583+0900 W/W_HOME  ( 2271): main.c: _resume_cb(589) > clock/widget resumed
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): clock_view.c: clock_view_event_handler(843) > event:10004 received
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb7b672d0 is resumed
06-06 17:31:55.583+0900 D/APP_CORE( 2271): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): main.c: _activate_window_job_cb(1242) > Activate the window
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): dbus_util.c: _dbus_message_send(97) > dbus_connection_send, ret=1
06-06 17:31:55.583+0900 E/W_HOME  ( 2271): dbus_util.c: home_dbus_home_raise_signal_send(259) > Sending HOME RAISE signal, result:0
06-06 17:31:55.583+0900 D/W_HOME  ( 2271): main.c: _resume_cb(564) > Resumed
06-06 17:31:55.583+0900 E/W_HOME  ( 2271): main.c: _resume_cb(567) > resumed already
06-06 17:31:55.583+0900 D/APP_CORE( 2271): appcore-efl.c: __hide_cb(848) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1600007
06-06 17:31:55.633+0900 D/AUL_AMD ( 2206): amd_launch.c: __e17_status_handler(1911) > pid(2271) status(3)
06-06 17:31:55.633+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2271, type = 0
06-06 17:31:55.633+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2271
06-06 17:31:55.633+0900 D/RESOURCED( 2396): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2271, appname = (null)
06-06 17:31:55.633+0900 D/RESOURCED( 2396): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2271
06-06 17:31:55.653+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=10
06-06 17:31:55.653+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_resume
06-06 17:31:55.653+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _ecore_evas_msg_parent_handle(1291) > ##### mc_resume
06-06 17:31:55.653+0900 D/DATA_PROVIDER_MASTER( 2300): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2271 is resumed
06-06 17:31:55.653+0900 D/DATA_PROVIDER_MASTER( 2300): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
06-06 17:31:55.763+0900 D/W_HOME  ( 2271): main.c: _window_focus_in_cb(848) > focus in
06-06 17:31:55.763+0900 D/W_HOME  ( 2271): main.c: _resume_cb(564) > Resumed
06-06 17:31:55.763+0900 E/W_HOME  ( 2271): main.c: _resume_cb(567) > resumed already
06-06 17:31:55.763+0900 E/APPS    ( 2271): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
06-06 17:31:55.763+0900 D/APP_CORE( 2271): appcore.c: __prt_ltime(183) > [APP 2271] first idle after reset: 9232991 msec
06-06 17:31:55.783+0900 W/W_HOME  ( 2271): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(0)
06-06 17:31:55.783+0900 D/APP_CORE( 2271): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 0
06-06 17:31:55.783+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
06-06 17:31:55.783+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
06-06 17:31:55.783+0900 D/APP_CORE( 2271): appcore-efl.c: __do_app(470) > [APP 2271] Event: RESUME State: RUNNING
06-06 17:31:55.783+0900 D/LAUNCH  ( 2271): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
06-06 17:31:55.783+0900 D/LAUNCH  ( 2271): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
06-06 17:31:55.783+0900 D/LAUNCH  ( 2271): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
06-06 17:31:55.783+0900 D/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-06 17:31:55.783+0900 E/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-06 17:31:55.783+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 8998, type = 2
06-06 17:31:55.813+0900 D/APP_CORE( 8998): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00003 fully_obscured 1
06-06 17:31:55.813+0900 D/APP_CORE( 8998): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
06-06 17:31:55.813+0900 D/APP_CORE( 8998): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
06-06 17:31:55.813+0900 D/APP_CORE( 8998): appcore-efl.c: __do_app(470) > [APP 8998] Event: PAUSE State: RUNNING
06-06 17:31:55.813+0900 D/APP_CORE( 8998): appcore-efl.c: __do_app(538) > [APP 8998] PAUSE
06-06 17:31:55.813+0900 I/CAPI_APPFW_APPLICATION( 8998): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-06 17:31:55.813+0900 D/APP_CORE( 8998): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-06 17:31:55.813+0900 E/APP_CORE( 8998): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-06 17:31:56.393+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:31:56.443+0900 D/EFL     ( 2271): ecore_x<2271> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9240397 button=1
06-06 17:31:56.443+0900 D/W_HOME  ( 2271): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
06-06 17:31:56.443+0900 D/W_HOME  ( 2271): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
06-06 17:31:56.443+0900 D/W_HOME  ( 2271): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:316
06-06 17:31:56.443+0900 D/W_HOME  ( 2271): layout.c: _down_cb(250) > Mouse is down on the layout
06-06 17:31:56.443+0900 W/W_HOME  ( 2271): layout.c: _down_cb(280) > we don't add a longpress timer, it's too close to home key
06-06 17:31:56.443+0900 D/W_HOME  ( 2271): page.c: _down_cb(84) > Down (0xb7b4cfa0)(169, 316)
06-06 17:31:56.523+0900 D/W_HOME  ( 2271): layout.c: _bezel_up_cb(348) > Bezel up cb
06-06 17:31:56.533+0900 D/APPS    ( 2271): apps_main.c: apps_main_launch(588) >  APPS LAUNCH
06-06 17:31:56.533+0900 D/APPS    ( 2271): apps_main.c: apps_main_launch(618) >  Show the Apps
06-06 17:31:56.533+0900 D/APPS    ( 2271): apps_main.c: apps_main_launch(625) >  There is a window already
06-06 17:31:56.533+0900 D/APPS    ( 2271): layout.c: apps_layout_show(476) >  (0xb7befd80) Show the tray
06-06 17:31:56.553+0900 D/APP_CORE( 2271): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600007
06-06 17:31:56.553+0900 D/APP_CORE( 2271): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1600007
06-06 17:31:56.553+0900 D/W_HOME  ( 2271): main.c: _window_focus_out_cb(869) > focus out
06-06 17:31:56.553+0900 D/W_HOME  ( 2271): main.c: _pause_cb(600) > Paused
06-06 17:31:56.553+0900 D/W_HOME  ( 2271): page.c: page_focus(701) > focus set to 0xb7bd1ab8
06-06 17:31:56.553+0900 W/W_HOME  ( 2271): main.c: _pause_cb(613) > clock/widget paused
06-06 17:31:56.553+0900 D/W_HOME  ( 2271): clock_view.c: clock_view_event_handler(843) > event:10002 received
06-06 17:31:56.553+0900 D/W_HOME  ( 2271): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb7b672d0 is paused
06-06 17:31:56.553+0900 E/APPS    ( 2271): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
06-06 17:31:56.553+0900 E/W_HOME  ( 2271): main.c: _window_focus_in_cb(851) > win[23068675], ev->win[23068679]
06-06 17:31:56.553+0900 D/APPS    ( 2271): apps_main.c: _window_focus_in_cb(288) >  focus in
06-06 17:31:56.553+0900 E/W_HOME  ( 2271): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-06 17:31:56.553+0900 D/APPS    ( 2271): apps_main.c: apps_main_resume(693) >  Resume starts
06-06 17:31:56.553+0900 D/APPS    ( 2271): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
06-06 17:31:56.553+0900 E/efl-extension( 2271): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb7bef650, elm_scroller, _activated_obj : 0xb7ae7668, activated : 1
06-06 17:31:56.553+0900 E/efl-extension( 2271): efl_extension_rotary.c: eext_rotary_object_event_activated_set(309) > Activation delete!!!!
06-06 17:31:56.563+0900 D/AUL_AMD ( 2206): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.w-home /usr/apps/org.tizen.w-home/bin/w-home
06-06 17:31:56.563+0900 D/RUA     ( 2206): rua.c: rua_add_history(179) > rua_add_history start
06-06 17:31:56.573+0900 D/RUA     ( 2206): rua.c: rua_add_history(247) > rua_add_history ok
06-06 17:31:56.573+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
06-06 17:31:56.573+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
06-06 17:31:56.573+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
06-06 17:31:56.573+0900 D/DATA_PROVIDER_MASTER( 2300): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2271 is paused
06-06 17:31:56.573+0900 D/DATA_PROVIDER_MASTER( 2300): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-06 17:31:56.633+0900 D/EFL     ( 2271): ecore_x<2271> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9240593 button=1
06-06 17:31:56.633+0900 D/W_HOME  ( 2271): layout.c: _up_cb(324) > Mouse is up on the layout
06-06 17:31:56.633+0900 D/W_HOME  ( 2271): page.c: _up_cb(115) > Up (0xb7b4cfa0)(282, 134)
06-06 17:31:56.633+0900 D/W_HOME  ( 2271): page.c: _up_cb(129) > Event ON_HOLD flag set on a page(0xb7b4cfa0)
06-06 17:31:56.633+0900 D/APP_CORE( 2271): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600007 fully_obscured 0
06-06 17:31:56.633+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 1
06-06 17:31:56.633+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(909) >  No change state 
06-06 17:31:56.633+0900 W/W_HOME  ( 2271): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
06-06 17:31:56.633+0900 D/APP_CORE( 2271): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
06-06 17:31:56.633+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 1
06-06 17:31:56.633+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(909) >  No change state 
06-06 17:31:57.163+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:31:57.213+0900 D/EFL     ( 2271): ecore_x<2271> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9241171 button=1
06-06 17:31:57.213+0900 D/APPS    ( 2271): scroller.c: _mouse_down_cb(100) >  Mouse is down [119,240]
06-06 17:31:57.213+0900 D/APPS    ( 2271): item.c: _down_cb(381) >  Down (Flying Bird,0xb7b78c00) (119, 240), item pos(32,187,154,134)
06-06 17:31:57.213+0900 E/APPS    ( 2271): item.c: _down_cb(425) >  longpress edit mode disable
06-06 17:31:57.233+0900 W/APPS    ( 2271): item.c: _anim_item_pressed_cb(1046) >  item is pressed
06-06 17:31:57.263+0900 D/EFL     ( 2271): ecore_x<2271> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9241242 button=1
06-06 17:31:57.263+0900 D/APPS    ( 2271): scroller.c: _mouse_up_cb(111) >  Mouse is up [119,240]
06-06 17:31:57.263+0900 D/APPS    ( 2271): item.c: _up_cb(573) >  Up (Flying Bird,0xb7b78c00) (119, 240), item pos(32,187,154,134)
06-06 17:31:57.263+0900 E/APPS    ( 2271): item.c: _clicked_cb(65) >  Clicked
06-06 17:31:57.263+0900 E/APPS    ( 2271): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
06-06 17:31:57.263+0900 D/APPS    ( 2271): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
06-06 17:31:57.263+0900 D/APP_SVC ( 2271): appsvc.c: __set_bundle(161) > __set_bundle
06-06 17:31:57.263+0900 D/APP_SVC ( 2271): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
06-06 17:31:57.263+0900 D/APP_SVC ( 2271): appsvc.c: __set_bundle(161) > __set_bundle
06-06 17:31:57.263+0900 D/W_HOME  ( 2271): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
06-06 17:31:57.263+0900 D/W_HOME  ( 2271): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
06-06 17:31:57.263+0900 D/APP_SVC ( 2271): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.exelim.flyingbird - no result
06-06 17:31:57.263+0900 D/AUL     ( 2271): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.exelim.flyingbird
06-06 17:31:57.263+0900 D/AUL     ( 2271): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
06-06 17:31:57.263+0900 D/AUL_AMD ( 2206): amd_request.c: __request_handler(495) > __request_handler: 0
06-06 17:31:57.263+0900 D/AUL_AMD ( 2206): amd_request.c: __request_handler(540) > launch a single-instance appid: org.exelim.flyingbird
06-06 17:31:57.263+0900 D/AUL_AMD ( 2206): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
06-06 17:31:57.263+0900 D/RESOURCED( 2396): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-06 17:31:57.263+0900 D/RESOURCED( 2396): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2206
06-06 17:31:57.263+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.exelim.flyingbird, pid 8998, type 5 
06-06 17:31:57.263+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(592) > [SECURE_LOG] [resourced_proc_status_change,592] resume request 8998
06-06 17:31:57.263+0900 D/AUL_AMD ( 2206): amd_launch.c: __nofork_processing(1008) > __nofork_processing, cmd: 0, pid: 8998
06-06 17:31:57.263+0900 D/AUL_AMD ( 2206): amd_launch.c: __nofork_processing(1024) > fake launch pid : 8998
06-06 17:31:57.263+0900 D/AUL     ( 2206): app_sock.c: __app_send_raw_with_delay_reply(435) > pid(8998) : cmd(0)
06-06 17:31:57.263+0900 D/AUL_AMD ( 2206): amd_launch.c: __set_reply_handler(873) > listen fd : 28, send fd : 27
06-06 17:31:57.263+0900 D/AUL_AMD ( 2206): amd_launch.c: __nofork_processing(1027) > fake launch done
06-06 17:31:57.323+0900 D/AUL_AMD ( 2206): amd_launch.c: __reply_handler(784) > listen fd(28) , send fd(27), pid(8998), cmd(0)
06-06 17:31:57.323+0900 D/APP_CORE( 8998): appcore.c: __aul_handler(423) > [APP 8998]     AUL event: AUL_START
06-06 17:31:57.323+0900 D/APP_CORE( 8998): appcore-efl.c: __do_app(470) > [APP 8998] Event: RESET State: PAUSED
06-06 17:31:57.323+0900 D/APP_CORE( 8998): appcore-efl.c: __do_app(496) > [APP 8998] RESET
06-06 17:31:57.323+0900 D/LAUNCH  ( 8998): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
06-06 17:31:57.323+0900 I/CAPI_APPFW_APPLICATION( 8998): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-06 17:31:57.323+0900 D/LAUNCH  ( 8998): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
06-06 17:31:57.323+0900 I/APP_CORE( 8998): appcore-efl.c: __do_app(514) > Legacy lifecycle: 0
06-06 17:31:57.323+0900 I/APP_CORE( 8998): appcore-efl.c: __do_app(516) > [APP 8998] App already running, raise the window
06-06 17:31:57.323+0900 D/AUL     ( 2271): launch.c: app_request_to_launchpad(295) > launch request result : 8998
06-06 17:31:57.323+0900 D/W_HOME  ( 2271): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.exelim.flyingbird:Flying Bird) ret : [0]
06-06 17:31:57.323+0900 D/LAUNCH  ( 2271): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.exelim.flyingbird:Menuscreen:launch:done]
06-06 17:31:57.323+0900 W/APPS    ( 2271): item.c: _anim_item_released_cb(1075) >  item is released
06-06 17:31:57.323+0900 D/APPS    ( 2271): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
06-06 17:31:57.323+0900 I/APP_CORE( 8998): appcore-efl.c: __do_app(520) > [APP 8998] Call the resume_cb
06-06 17:31:57.323+0900 I/CAPI_APPFW_APPLICATION( 8998): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-06 17:31:57.323+0900 D/APP_CORE( 8998): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : org.tizen.w-home
06-06 17:31:57.323+0900 D/AUL_AMD ( 2206): amd_launch.c: __e17_status_handler(1911) > pid(8998) status(3)
06-06 17:31:57.323+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 8998, type = 0
06-06 17:31:57.323+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 8998
06-06 17:31:57.323+0900 D/RESOURCED( 2396): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 8998, appname = (null)
06-06 17:31:57.323+0900 D/RESOURCED( 2396): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8998
06-06 17:31:57.403+0900 D/APP_CORE( 8998): appcore.c: __prt_ltime(183) > [APP 8998] first idle after reset: 25914 msec
06-06 17:31:57.443+0900 E/W_HOME  ( 2271): main.c: _window_focus_out_cb(885) > win[23068675], ev->win[23068679]
06-06 17:31:57.443+0900 D/APPS    ( 2271): apps_main.c: _window_focus_out_cb(308) >  focus out
06-06 17:31:57.443+0900 E/W_HOME  ( 2271): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-06 17:31:57.443+0900 D/APPS    ( 2271): apps_main.c: apps_main_pause(656) >  Pause starts
06-06 17:31:57.443+0900 D/APPS    ( 2271): apps_main.c: apps_main_pause(676) >  Pause done
06-06 17:31:57.463+0900 D/APP_CORE( 2271): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600007 fully_obscured 1
06-06 17:31:57.463+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
06-06 17:31:57.463+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
06-06 17:31:57.463+0900 D/APP_CORE( 2271): appcore-efl.c: __do_app(470) > [APP 2271] Event: PAUSE State: RUNNING
06-06 17:31:57.463+0900 D/APP_CORE( 2271): appcore-efl.c: __do_app(538) > [APP 2271] PAUSE
06-06 17:31:57.463+0900 I/CAPI_APPFW_APPLICATION( 2271): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-06 17:31:57.463+0900 D/W_HOME  ( 2271): main.c: _pause_cb(600) > Paused
06-06 17:31:57.463+0900 E/W_HOME  ( 2271): main.c: _pause_cb(603) > paused already
06-06 17:31:57.463+0900 D/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-06 17:31:57.463+0900 E/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-06 17:31:57.473+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2271, type = 2
06-06 17:31:57.503+0900 D/APP_CORE( 8998): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00003 fully_obscured 0
06-06 17:31:57.503+0900 D/APP_CORE( 8998): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
06-06 17:31:57.503+0900 D/APP_CORE( 8998): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
06-06 17:31:57.503+0900 D/APP_CORE( 8998): appcore-efl.c: __do_app(470) > [APP 8998] Event: RESUME State: RUNNING
06-06 17:31:57.503+0900 D/LAUNCH  ( 8998): appcore-efl.c: __do_app(557) > [flyingbird:Application:resume:start]
06-06 17:31:57.503+0900 D/LAUNCH  ( 8998): appcore-efl.c: __do_app(567) > [flyingbird:Application:resume:done]
06-06 17:31:57.503+0900 D/LAUNCH  ( 8998): appcore-efl.c: __do_app(569) > [flyingbird:Application:Launching:done]
06-06 17:31:57.503+0900 D/APP_CORE( 8998): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-06 17:31:57.503+0900 E/APP_CORE( 8998): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-06 17:31:58.263+0900 D/AUL_AMD ( 2206): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.exelim.flyingbird /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
06-06 17:31:58.263+0900 D/RUA     ( 2206): rua.c: rua_add_history(179) > rua_add_history start
06-06 17:31:58.283+0900 D/RUA     ( 2206): rua.c: rua_add_history(247) > rua_add_history ok
06-06 17:32:00.223+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2272): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-06 17:32:00.223+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2272): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-06 17:32:00.223+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2272): preference.c: preference_get_int(1063) > preference_get_int(2272) : key(clock_font_color) error
06-06 17:32:00.223+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2272): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-06 17:32:00.223+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2272): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-06 17:32:00.223+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2272): preference.c: preference_get_int(1063) > preference_get_int(2272) : key(showdate) error
06-06 17:32:00.223+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: clock_view_set_info_time(849) > show_date:1
06-06 17:32:00.223+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(9)[Mon 6 Jun][1465201920]
06-06 17:32:00.223+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: clock_view_set_info_time(857) > 
06-06 17:32:00.223+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1465201920]
06-06 17:32:00.223+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[5:32][1465201920]
06-06 17:32:00.223+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: clock_view_set_info_time(871) > utc_time=5:32, utc_ampm=[2]PM
06-06 17:32:00.223+0900 D/IDLE-CLOCK-DIGITAL( 2272): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>5:32<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
06-06 17:32:00.243+0900 D/AUL_AMD ( 2206): amd_launch.c: __e17_status_handler(1911) > pid(2271) status(3)
06-06 17:32:00.243+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2271, type = 0
06-06 17:32:00.243+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2271
06-06 17:32:00.243+0900 D/RESOURCED( 2396): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2271, appname = (null)
06-06 17:32:00.243+0900 D/RESOURCED( 2396): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2271
06-06 17:32:00.373+0900 E/W_HOME  ( 2271): main.c: _window_focus_in_cb(851) > win[23068675], ev->win[23068679]
06-06 17:32:00.373+0900 D/APPS    ( 2271): apps_main.c: _window_focus_in_cb(288) >  focus in
06-06 17:32:00.373+0900 E/W_HOME  ( 2271): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-06 17:32:00.373+0900 D/APPS    ( 2271): apps_main.c: apps_main_resume(693) >  Resume starts
06-06 17:32:00.373+0900 D/APPS    ( 2271): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
06-06 17:32:00.373+0900 E/efl-extension( 2271): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb7bef650, elm_scroller, _activated_obj : 0xb7bef650, activated : 1
06-06 17:32:00.373+0900 D/APP_CORE( 2271): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600007 fully_obscured 0
06-06 17:32:00.373+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
06-06 17:32:00.373+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
06-06 17:32:00.373+0900 D/APP_CORE( 2271): appcore-efl.c: __do_app(470) > [APP 2271] Event: RESUME State: PAUSED
06-06 17:32:00.373+0900 D/LAUNCH  ( 2271): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
06-06 17:32:00.373+0900 D/APP_CORE( 2271): appcore-efl.c: __do_app(559) > [APP 2271] RESUME
06-06 17:32:00.373+0900 I/CAPI_APPFW_APPLICATION( 2271): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-06 17:32:00.373+0900 D/W_HOME  ( 2271): main.c: _resume_cb(564) > Resumed
06-06 17:32:00.373+0900 D/APPS    ( 2271): apps_main.c: apps_main_is_visible(757) >  bShow:[1]
06-06 17:32:00.373+0900 E/W_HOME  ( 2271): main.c: _resume_cb(576) > Apps is showing
06-06 17:32:00.373+0900 D/LAUNCH  ( 2271): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
06-06 17:32:00.373+0900 D/LAUNCH  ( 2271): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
06-06 17:32:00.373+0900 D/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-06 17:32:00.373+0900 E/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-06 17:32:01.553+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:32:01.613+0900 D/EFL     ( 2271): ecore_x<2271> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9245563 button=1
06-06 17:32:01.613+0900 D/APPS    ( 2271): scroller.c: _mouse_down_cb(100) >  Mouse is down [145,242]
06-06 17:32:01.613+0900 D/APPS    ( 2271): item.c: _down_cb(381) >  Down (Flying Bird,0xb7b78c00) (145, 242), item pos(32,187,154,134)
06-06 17:32:01.613+0900 E/APPS    ( 2271): item.c: _down_cb(425) >  longpress edit mode disable
06-06 17:32:01.613+0900 D/EFL     ( 2271): ecore_x<2271> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9245626 button=1
06-06 17:32:01.613+0900 D/APPS    ( 2271): scroller.c: _mouse_up_cb(111) >  Mouse is up [145,242]
06-06 17:32:01.613+0900 D/APPS    ( 2271): item.c: _up_cb(573) >  Up (Flying Bird,0xb7b78c00) (145, 242), item pos(32,187,154,134)
06-06 17:32:01.613+0900 E/APPS    ( 2271): item.c: _clicked_cb(65) >  Clicked
06-06 17:32:01.613+0900 E/APPS    ( 2271): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
06-06 17:32:01.613+0900 D/APPS    ( 2271): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
06-06 17:32:01.613+0900 D/APP_SVC ( 2271): appsvc.c: __set_bundle(161) > __set_bundle
06-06 17:32:01.613+0900 D/APP_SVC ( 2271): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
06-06 17:32:01.613+0900 D/APP_SVC ( 2271): appsvc.c: __set_bundle(161) > __set_bundle
06-06 17:32:01.623+0900 D/W_HOME  ( 2271): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
06-06 17:32:01.623+0900 D/W_HOME  ( 2271): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
06-06 17:32:01.623+0900 D/APP_SVC ( 2271): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.exelim.flyingbird - no result
06-06 17:32:01.623+0900 D/AUL     ( 2271): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.exelim.flyingbird
06-06 17:32:01.623+0900 D/AUL     ( 2271): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_request.c: __request_handler(495) > __request_handler: 0
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_request.c: __request_handler(540) > launch a single-instance appid: org.exelim.flyingbird
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
06-06 17:32:01.623+0900 E/AUL_AMD ( 2206): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_launch.c: _start_app(1785) > process_pool: false
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_launch.c: _start_app(1788) > h/w acceleration: USE
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.exelim.flyingbird
06-06 17:32:01.623+0900 D/AUL_AMD ( 2206): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-06 17:32:01.623+0900 D/AUL     ( 2206): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
06-06 17:32:01.623+0900 D/AUL_PAD ( 2228): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.exelim.flyingbird
06-06 17:32:01.623+0900 D/AUL_PAD ( 2228): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
06-06 17:32:01.623+0900 D/AUL_PAD ( 2228): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 9006 /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
06-06 17:32:01.623+0900 D/AUL_PAD ( 2228): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
06-06 17:32:01.623+0900 D/AUL_PAD ( 9006): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
06-06 17:32:01.623+0900 D/AUL_PAD ( 9006): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
06-06 17:32:01.623+0900 D/AUL_PAD ( 9006): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.exelim.flyingbird / pkg_type : rpm / app_path : /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird 
06-06 17:32:01.643+0900 D/AUL_PAD ( 9006): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
06-06 17:32:01.643+0900 D/AUL_PAD ( 9006): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird##
06-06 17:32:01.643+0900 D/AUL_PAD ( 9006): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-06 17:32:01.643+0900 D/AUL_PAD ( 9006): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-06 17:32:01.643+0900 D/AUL_PAD ( 9006): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-06 17:32:01.643+0900 D/AUL_PAD ( 9006): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-06 17:32:01.643+0900 D/AUL_PAD ( 9006): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-06 17:32:01.643+0900 D/LAUNCH  ( 9006): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird:Platform:launchpad:done]
06-06 17:32:01.663+0900 I/efl-extension( 9006): efl_extension.c: eext_mod_init(39) > Init
06-06 17:32:01.663+0900 I/CAPI_APPFW_APPLICATION( 9006): app_main.c: ui_app_main(701) > app_efl_main
06-06 17:32:01.663+0900 D/LAUNCH  ( 9006): appcore-efl.c: appcore_efl_main(1571) > [flyingbird:Application:main:done]
06-06 17:32:01.683+0900 D/APP_CORE( 9006): appcore-efl.c: __before_loop(1012) > elm_config_preferred_engine_set : opengl_x11
06-06 17:32:01.683+0900 D/AUL     ( 9006): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 9006 is org.exelim.flyingbird
06-06 17:32:01.683+0900 D/APP_CORE( 9006): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.exelim.flyingbird/res/locale
06-06 17:32:01.683+0900 D/APP_CORE( 9006): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
06-06 17:32:01.683+0900 D/AUL     ( 9006): app_sock.c: __create_server_sock(136) > pg path - already exists
06-06 17:32:01.683+0900 D/LAUNCH  ( 9006): appcore-efl.c: __before_loop(1035) > [flyingbird:Platform:appcore_init:done]
06-06 17:32:01.683+0900 I/CAPI_APPFW_APPLICATION( 9006): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
06-06 17:32:01.723+0900 D/AUL_PAD ( 2228): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
06-06 17:32:01.723+0900 D/AUL_PAD ( 2228): sigchild.h: __send_app_launch_signal(112) > send launch signal done
06-06 17:32:01.723+0900 D/AUL_PAD ( 2228): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
06-06 17:32:01.723+0900 D/AUL     ( 2206): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-06 17:32:01.723+0900 E/AUL     ( 2206): simple_util.c: __trm_app_info_send_socket(264) > access
06-06 17:32:01.723+0900 D/RESOURCED( 2396): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-06 17:32:01.723+0900 D/RESOURCED( 2396): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2206
06-06 17:32:01.723+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.exelim.flyingbird, pid 9006, type 4 
06-06 17:32:01.723+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.exelim.flyingbird, 9006
06-06 17:32:01.723+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.exelim.flyingbird with pkgname
06-06 17:32:01.723+0900 E/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 375
06-06 17:32:01.723+0900 D/RESOURCED( 2396): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-06 17:32:01.723+0900 D/AUL     ( 2271): launch.c: app_request_to_launchpad(295) > launch request result : 9006
06-06 17:32:01.723+0900 D/W_HOME  ( 2271): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.exelim.flyingbird:Flying Bird) ret : [0]
06-06 17:32:01.723+0900 D/LAUNCH  ( 2271): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.exelim.flyingbird:Menuscreen:launch:done]
06-06 17:32:01.723+0900 W/APPS    ( 2271): item.c: _anim_item_released_cb(1075) >  item is released
06-06 17:32:01.723+0900 D/APPS    ( 2271): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
06-06 17:32:01.873+0900 E/EFL     ( 9006): eina_module<9006> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-06 17:32:01.873+0900 E/EFL     ( 9006): ecore_evas<9006> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
06-06 17:32:01.873+0900 E/W_HOME  ( 2271): main.c: _window_focus_out_cb(885) > win[23068675], ev->win[23068679]
06-06 17:32:01.873+0900 D/APPS    ( 2271): apps_main.c: _window_focus_out_cb(308) >  focus out
06-06 17:32:01.873+0900 E/W_HOME  ( 2271): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-06 17:32:01.873+0900 D/APPS    ( 2271): apps_main.c: apps_main_pause(656) >  Pause starts
06-06 17:32:01.873+0900 D/APPS    ( 2271): apps_main.c: apps_main_pause(676) >  Pause done
06-06 17:32:01.883+0900 D/LAUNCH  ( 9006): appcore-efl.c: __before_loop(1047) > [flyingbird:Application:create:done]
06-06 17:32:01.883+0900 D/APP_CORE( 9006): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
06-06 17:32:01.883+0900 D/APP_CORE( 9006): appcore.c: __aul_handler(423) > [APP 9006]     AUL event: AUL_START
06-06 17:32:01.883+0900 D/APP_CORE( 9006): appcore-efl.c: __do_app(470) > [APP 9006] Event: RESET State: CREATED
06-06 17:32:01.883+0900 D/APP_CORE( 9006): appcore-efl.c: __do_app(496) > [APP 9006] RESET
06-06 17:32:01.883+0900 D/LAUNCH  ( 9006): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
06-06 17:32:01.883+0900 I/CAPI_APPFW_APPLICATION( 9006): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-06 17:32:01.883+0900 D/LAUNCH  ( 9006): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
06-06 17:32:01.883+0900 I/APP_CORE( 9006): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
06-06 17:32:01.883+0900 I/APP_CORE( 9006): appcore-efl.c: __do_app(509) > [APP 9006] Initial Launching, call the resume_cb
06-06 17:32:01.883+0900 I/CAPI_APPFW_APPLICATION( 9006): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-06 17:32:01.883+0900 D/APP_CORE( 9006): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : org.tizen.w-home
06-06 17:32:01.883+0900 D/APP_CORE( 9006): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00003
06-06 17:32:01.883+0900 D/APP_CORE( 9006): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00003
06-06 17:32:01.953+0900 D/APP_CORE( 9006): appcore.c: __prt_ltime(183) > [APP 9006] first idle after reset: 333 msec
06-06 17:32:01.953+0900 D/APP_CORE( 2271): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600007 fully_obscured 1
06-06 17:32:01.953+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
06-06 17:32:01.953+0900 D/APP_CORE( 2271): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
06-06 17:32:01.953+0900 D/APP_CORE( 2271): appcore-efl.c: __do_app(470) > [APP 2271] Event: PAUSE State: RUNNING
06-06 17:32:01.953+0900 D/APP_CORE( 2271): appcore-efl.c: __do_app(538) > [APP 2271] PAUSE
06-06 17:32:01.953+0900 I/CAPI_APPFW_APPLICATION( 2271): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-06 17:32:01.953+0900 D/W_HOME  ( 2271): main.c: _pause_cb(600) > Paused
06-06 17:32:01.953+0900 E/W_HOME  ( 2271): main.c: _pause_cb(603) > paused already
06-06 17:32:01.953+0900 D/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-06 17:32:01.953+0900 E/APP_CORE( 2271): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-06 17:32:01.953+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2271, type = 2
06-06 17:32:01.953+0900 D/AUL_AMD ( 2206): amd_launch.c: __e17_status_handler(1911) > pid(9006) status(3)
06-06 17:32:01.953+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 9006, type = 0
06-06 17:32:01.953+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 9006
06-06 17:32:01.953+0900 I/RESOURCED( 2396): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 9006, oom : 200
06-06 17:32:01.953+0900 E/RESOURCED( 2396): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
06-06 17:32:01.983+0900 D/APP_CORE( 9006): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00003 fully_obscured 0
06-06 17:32:01.983+0900 D/APP_CORE( 9006): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
06-06 17:32:01.983+0900 D/APP_CORE( 9006): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
06-06 17:32:01.983+0900 D/APP_CORE( 9006): appcore-efl.c: __do_app(470) > [APP 9006] Event: RESUME State: RUNNING
06-06 17:32:01.983+0900 D/LAUNCH  ( 9006): appcore-efl.c: __do_app(557) > [flyingbird:Application:resume:start]
06-06 17:32:01.983+0900 D/LAUNCH  ( 9006): appcore-efl.c: __do_app(567) > [flyingbird:Application:resume:done]
06-06 17:32:01.983+0900 D/LAUNCH  ( 9006): appcore-efl.c: __do_app(569) > [flyingbird:Application:Launching:done]
06-06 17:32:01.983+0900 D/APP_CORE( 9006): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-06 17:32:01.983+0900 E/APP_CORE( 9006): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-06 17:32:02.183+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:32:02.253+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9246238 button=1
06-06 17:32:02.253+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9246257 button=1
06-06 17:32:02.733+0900 D/AUL_AMD ( 2206): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.exelim.flyingbird /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
06-06 17:32:02.733+0900 D/RUA     ( 2206): rua.c: rua_add_history(179) > rua_add_history start
06-06 17:32:02.733+0900 D/RUA     ( 2206): rua.c: rua_add_history(247) > rua_add_history ok
06-06 17:32:02.863+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:32:02.913+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9246925 button=1
06-06 17:32:02.973+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9246977 button=1
06-06 17:32:03.303+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:32:03.363+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9247348 button=1
06-06 17:32:03.423+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9247433 button=1
06-06 17:32:03.693+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:32:03.753+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9247736 button=1
06-06 17:32:03.843+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9247834 button=1
06-06 17:32:04.183+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:32:04.233+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9248245 button=1
06-06 17:32:04.353+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=9248353 button=1
06-06 17:32:04.693+0900 I/GESTURE ( 2054): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-06 17:32:04.773+0900 D/EFL     ( 9006): ecore_x<9006> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=9248756 button=1
06-06 17:32:04.843+0900 D/AUL_AMD ( 2206): amd_launch.c: __e17_status_handler(1911) > pid(2271) status(3)
06-06 17:32:04.843+0900 D/RESOURCED( 2396): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2271, type = 0
06-06 17:32:04.843+0900 D/RESOURCED( 2396): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2271
06-06 17:32:04.843+0900 D/RESOURCED( 2396): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2271, appname = (null)
06-06 17:32:04.843+0900 D/RESOURCED( 2396): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2271
06-06 17:32:04.913+0900 W/CRASH_MANAGER( 9007): worker.c: worker_job(1189) > 1109006666c79146520192
