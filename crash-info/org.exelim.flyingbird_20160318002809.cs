S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20150902.2338
Build-Date: 2015.09.02 23:38:00

Crash Information
Process Name: flyingbird
PID: 30083
Date: 2016-03-18 00:28:09+0900
Executable File Path: /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x42340000

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x80160e30, esi = 0x80168b60
ebp = 0xbffff418, esp = 0xbffff3d0
eax = 0x8019ce08, ebx = 0x800151d4
ecx = 0x00000008, edx = 0x42340000
eip = 0x8000d2f6

Memory Information
MemTotal:      124 KB
MemFree:        47 KB
Buffers:        12 KB
Cached:     155700 KB
VmPeak:      66244 KB
VmSize:      66244 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16796 KB
VmRSS:       16796 KB
VmData:       5780 KB
VmStk:         136 KB
VmExe:          84 KB
VmLib:       32032 KB
VmPTE:          56 KB
VmSwap:          0 KB

Maps Information
80000000 80015000 r-xp /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
b44fd000 b4521000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b468c000 b468f000 r-xp /usr/lib/libdri2.so.0.0.0
b4690000 b4699000 r-xp /usr/lib/libtbm.so.1.0.0
b469f000 b46ad000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b46ae000 b46b1000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b46b2000 b46bd000 r-xp /usr/lib/libdrm.so.2.4.0
b46be000 b46d7000 r-xp /usr/lib/yagl/libEGL.so.1.0
b46d8000 b4720000 r-xp /usr/lib/yagl/libGLESv2.so.2.0
b4723000 b47ad000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so
b47b6000 b47c1000 r-xp /lib/libnss_files-2.13.so
b47c3000 b47ea000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b47eb000 b4810000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4811000 b4931000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4941000 b4977000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4cde000 b4ce4000 r-xp /usr/lib/libogg.so.0.7.1
b4ce5000 b4d10000 r-xp /usr/lib/libvorbis.so.0.4.3
b4d11000 b4dfc000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4e0a000 b4e0b000 r-xp /usr/lib/libjournal.so.0.1.0
b4e0c000 b4f54000 r-xp /usr/lib/libxml2.so.2.7.8
b4f5b000 b4f6e000 r-xp /lib/libresolv-2.13.so
b4f72000 b4f75000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4f76000 b4fd6000 r-xp /usr/lib/libssl.so.1.0.0
b4fdb000 b500c000 r-xp /usr/lib/libidn.so.11.5.44
b500d000 b501d000 r-xp /usr/lib/libcares.so.2.1.0
b501f000 b5021000 r-xp /usr/lib/libXau.so.6.0.0
b5022000 b508b000 r-xp /usr/lib/libsndfile.so.1.0.25
b5091000 b509b000 r-xp /usr/lib/libsensord-share.so
b509c000 b50a1000 r-xp /usr/lib/libffi.so.5.0.10
b50a3000 b50a4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b50a5000 b50a8000 r-xp /usr/lib/libiniparser.so.0
b50aa000 b52bc000 r-xp /usr/lib/libcrypto.so.1.0.0
b52d7000 b52f8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b52fa000 b545b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b545f000 b5466000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b5468000 b54d7000 r-xp /usr/lib/libcurl.so.4.3.0
b54d9000 b54e4000 r-xp /usr/lib/libethumb.so.1.7.99
b6a45000 b6a48000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6a49000 b6a4f000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6a50000 b6a56000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6a58000 b6a9e000 r-xp /usr/lib/libjpeg.so.8.0.2
b6aaf000 b6ad5000 r-xp /lib/libexpat.so.1.5.2
b6ad8000 b6af5000 r-xp /lib/libz.so.1.2.5
b6af6000 b6b16000 r-xp /usr/lib/libxcb.so.1.1.0
b6b17000 b6b1f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b6b20000 b6b22000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6b23000 b6b4a000 r-xp /usr/lib/libpng12.so.0.50.0
b6b4c000 b6b4f000 r-xp /usr/lib/libctxdata.so.0.0.0
b6b50000 b6b66000 r-xp /usr/lib/libremix.so.0.0.0
b6b67000 b6b69000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6b6a000 b6b96000 r-xp /usr/lib/liblua-5.1.so
b6b97000 b6ba1000 r-xp /usr/lib/libembryo.so.1.7.99
b6ba3000 b6bb4000 r-xp /usr/lib/libXext.so.6.4.0
b6bb5000 b6bba000 r-xp /usr/lib/libXtst.so.6.1.0
b6bbb000 b6bc3000 r-xp /usr/lib/libXrender.so.1.3.0
b6bc4000 b6bcd000 r-xp /usr/lib/libXrandr.so.2.2.0
b6bce000 b6bd0000 r-xp /usr/lib/libXinerama.so.1.0.0
b6bd2000 b6bd6000 r-xp /usr/lib/libXfixes.so.3.1.0
b6bd7000 b6bd9000 r-xp /usr/lib/libXgesture.so.7.0.0
b6bda000 b6bdc000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6bdd000 b6bdf000 r-xp /usr/lib/libXdamage.so.1.1.0
b6be0000 b6be9000 r-xp /usr/lib/libXcursor.so.1.0.2
b6beb000 b6c09000 r-xp /usr/lib/libsensor.so.1.1.0
b6c0b000 b6c59000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6c5a000 b6c64000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b6c65000 b6c6e000 r-xp /usr/lib/libappsvc.so.0.1.0
b6c6f000 b6c7a000 r-xp /usr/lib/libvconf.so.0.2.45
b6c7c000 b6d24000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6d27000 b6d2a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6d2b000 b6d57000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6d58000 b6d5d000 r-xp /usr/lib/libsmack.so.1.0.0
b6d5e000 b6d67000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6d69000 b6db3000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6db4000 b6dd9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6dda000 b6ddf000 r-xp /usr/lib/libbundle.so.0.1.22
b6de0000 b6e62000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6e67000 b6ec2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6ec5000 b6edb000 r-xp /usr/lib/libfribidi.so.0.3.1
b6edc000 b6f68000 r-xp /usr/lib/libfreetype.so.6.11.3
b6f6c000 b6f97000 r-xp /usr/lib/libecore_con.so.1.7.99
b6f99000 b6fa1000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6fa2000 b6fad000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6fae000 b6fb4000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6fb6000 b6fd7000 r-xp /usr/lib/libefreet.so.1.7.99
b6fd9000 b6fe5000 r-xp /usr/lib/libedbus.so.1.7.99
b6fe6000 b7145000 r-xp /usr/lib/libicuuc.so.51.1
b7153000 b735c000 r-xp /usr/lib/libicui18n.so.51.1
b7365000 b7376000 r-xp /usr/lib/libecore_input.so.1.7.99
b7378000 b737f000 r-xp /usr/lib/libecore_file.so.1.7.99
b7380000 b73b3000 r-xp /usr/lib/libecore_evas.so.1.7.99
b73b5000 b73db000 r-xp /usr/lib/libeet.so.1.7.99
b73e4000 b7418000 r-xp /usr/lib/libfontconfig.so.1.5.0
b741a000 b7428000 r-xp /usr/lib/libXi.so.6.1.0
b742a000 b755e000 r-xp /usr/lib/libX11.so.6.3.0
b7562000 b76a6000 r-xp /usr/lib/libcairo.so.2.11200.14
b76aa000 b7747000 r-xp /usr/lib/libedje.so.1.7.99
b7749000 b778d000 r-xp /usr/lib/libecore_x.so.1.7.99
b778f000 b7796000 r-xp /lib/librt-2.13.so
b7799000 b78bc000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b78bd000 b78d4000 r-xp /lib/libpthread-2.13.so
b78d8000 b7933000 r-xp /usr/lib/libeina.so.1.7.99
b7935000 b793b000 r-xp /usr/lib/libappcore-common.so.1.1
b793c000 b7941000 r-xp /usr/lib/libappcore-efl.so.1.1
b7943000 b7949000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b794a000 b795d000 r-xp /usr/lib/libail.so.0.1.0
b795e000 b796e000 r-xp /usr/lib/libaul.so.0.1.0
b7970000 b7973000 r-xp /lib/libdl-2.13.so
b7975000 b797f000 r-xp /lib/libunwind.so.8.0.1
b798a000 b79a4000 r-xp /lib/libgcc_s-4.6.4.so.1
b79a5000 b7b16000 r-xp /lib/libc-2.13.so
b7b1c000 b7b44000 r-xp /lib/libm-2.13.so
b7b46000 b7c1e000 r-xp /usr/lib/libstdc++.so.6.0.16
b7c2a000 b7d52000 r-xp /usr/lib/libevas.so.1.7.99
b7d6f000 b7f69000 r-xp /usr/lib/libelementary.so.1.7.99
b7f79000 b7f9a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b7f9b000 b7fbb000 r-xp /usr/lib/libecore.so.1.7.99
b7fca000 b7fcd000 r-xp /usr/lib/libdlog.so.0.0.0
b7fce000 b7fd2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7fd3000 b7fd6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b7fd7000 b7fdc000 r-xp /usr/lib/libsys-assert.so
b7fdf000 b7ffd000 r-xp /lib/ld-2.13.so
b7ffd000 b7ffe000 r-xp [vdso]
End of Maps Information

Callstack Information (PID:30083)
Call Stack Count: 19
 0: Screen::Draw(double, double) + 0x66 (0x8000d2f6) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xd2f6
 1: Game::Draw(double) + 0x39 (0x80005f01) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x5f01
 2: draw_gl(_Evas_Object*) + 0xbc (0x8000e30b) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xe30b
 3: (0xb7e4532d) [/usr/lib/libelementary.so.1] + 0xd632d
 4: (0xb472e42d) [/usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so] + 0xb42d
 5: (0xb7c581c1) [/usr/lib/libevas.so.1] + 0x2e1c1
 6: (0xb7ca5635) [/usr/lib/libevas.so.1] + 0x7b635
 7: (0xb7ca9305) [/usr/lib/libevas.so.1] + 0x7f305
 8: (0xb73958d7) [/usr/lib/libecore_evas.so.1] + 0x158d7
 9: ecore_evas_manual_render + 0x5d (0xb73905cd) [/usr/lib/libecore_evas.so.1] + 0x105cd
10: (0xb7394879) [/usr/lib/libecore_evas.so.1] + 0x14879
11: (0xb7fa7852) [/usr/lib/libecore.so.1] + 0xc852
12: (0xb7fa92fd) [/usr/lib/libecore.so.1] + 0xe2fd
13: ecore_main_loop_begin + 0x3f (0xb7fa99cf) [/usr/lib/libecore.so.1] + 0xe9cf
14: elm_run + 0x17 (0xb7e76867) [/usr/lib/libelementary.so.1] + 0x107867
15: appcore_efl_main + 0x3d1 (0xb793ee91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
16: ui_app_main + 0x130 (0xb7fd0500) [/usr/lib/libcapi-appfw-application.so.0] + 0x2500
17: main + 0xb9 (0x8000ea2d) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xea2d
18: __libc_start_main + 0xf3 (0xb79be0f3) [/lib/libc.so.6] + 0x190f3
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
sage(169) > [process_message,169] process message caller pid 2100
03-18 00:27:46.841+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.exelim.flyingbird, pid 29931, type 4 
03-18 00:27:46.841+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.exelim.flyingbird, 29931
03-18 00:27:46.841+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.exelim.flyingbird with pkgname
03-18 00:27:46.841+0900 E/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 348
03-18 00:27:46.841+0900 D/RESOURCED( 2344): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 00:27:47.831+0900 D/AUL_AMD ( 2100): amd_launch.c: __grab_timeout_handler(1212) > pid(29931) ecore_x_pointer_ungrab
03-18 00:27:47.831+0900 D/AUL_AMD ( 2100): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.exelim.flyingbird /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
03-18 00:27:47.831+0900 D/RUA     ( 2100): rua.c: rua_add_history(179) > rua_add_history start
03-18 00:27:47.841+0900 D/RUA     ( 2100): rua.c: rua_add_history(247) > rua_add_history ok
03-18 00:27:48.001+0900 I/efl-extension(29933): efl_extension.c: eext_mod_init(39) > Init
03-18 00:27:48.001+0900 D/AUL     (29933): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 29933 is org.exelim.flyingbird
03-18 00:27:48.001+0900 I/CAPI_APPFW_APPLICATION(29933): app_main.c: ui_app_main(701) > app_efl_main
03-18 00:27:48.001+0900 D/LAUNCH  (29933): appcore-efl.c: appcore_efl_main(1571) > [flyingbird:Application:main:done]
03-18 00:27:48.001+0900 D/AUL     (29933): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 29933 is org.exelim.flyingbird
03-18 00:27:48.161+0900 D/APP_CORE(29933): appcore-efl.c: __before_loop(1012) > elm_config_preferred_engine_set : opengl_x11
03-18 00:27:48.161+0900 D/AUL     (29933): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 29933 is org.exelim.flyingbird
03-18 00:27:48.161+0900 D/APP_CORE(29933): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.exelim.flyingbird/res/locale
03-18 00:27:48.161+0900 D/APP_CORE(29933): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 00:27:48.161+0900 D/AUL     (29933): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 00:27:48.161+0900 D/LAUNCH  (29933): appcore-efl.c: __before_loop(1035) > [flyingbird:Platform:appcore_init:done]
03-18 00:27:48.161+0900 I/CAPI_APPFW_APPLICATION(29933): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 00:27:48.661+0900 D/W_HOME  ( 2221): main.c: _window_focus_out_cb(869) > focus out
03-18 00:27:48.661+0900 D/W_HOME  ( 2221): main.c: _pause_cb(600) > Paused
03-18 00:27:48.661+0900 D/W_HOME  ( 2221): page.c: page_focus(701) > focus set to 0xb94374f8
03-18 00:27:48.661+0900 W/W_HOME  ( 2221): main.c: _pause_cb(613) > clock/widget paused
03-18 00:27:48.661+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-18 00:27:48.661+0900 E/APPS    ( 2221): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
03-18 00:27:48.671+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2221 is paused
03-18 00:27:48.671+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-18 00:27:48.671+0900 D/LAUNCH  (29933): appcore-efl.c: __before_loop(1047) > [flyingbird:Application:create:done]
03-18 00:27:48.671+0900 D/APP_CORE(29933): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-18 00:27:48.671+0900 D/APP_CORE(29933): appcore.c: __aul_handler(423) > [APP 29933]     AUL event: AUL_START
03-18 00:27:48.671+0900 D/APP_CORE(29933): appcore-efl.c: __do_app(470) > [APP 29933] Event: RESET State: CREATED
03-18 00:27:48.671+0900 D/APP_CORE(29933): appcore-efl.c: __do_app(496) > [APP 29933] RESET
03-18 00:27:48.671+0900 D/LAUNCH  (29933): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
03-18 00:27:48.671+0900 I/CAPI_APPFW_APPLICATION(29933): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-18 00:27:48.671+0900 D/APP_SVC (29933): appsvc.c: __set_bundle(161) > __set_bundle
03-18 00:27:48.671+0900 D/LAUNCH  (29933): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
03-18 00:27:48.671+0900 E/PKGMGR_INFO(29933): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1327) > (appid == NULL) appid is NULL
03-18 00:27:48.671+0900 I/APP_CORE(29933): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-18 00:27:48.671+0900 I/APP_CORE(29933): appcore-efl.c: __do_app(509) > [APP 29933] Initial Launching, call the resume_cb
03-18 00:27:48.671+0900 I/CAPI_APPFW_APPLICATION(29933): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-18 00:27:48.671+0900 D/APP_CORE(29933): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-18 00:27:48.681+0900 D/APP_CORE(29933): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00003
03-18 00:27:48.681+0900 D/APP_CORE(29933): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1a00003
03-18 00:27:48.681+0900 D/AUL     (29933): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 29933 is org.exelim.flyingbird
03-18 00:27:53.391+0900 W/CRASH_MANAGER(29937): worker.c: worker_job(1189) > 1129933666c791458228473
03-18 00:27:54.251+0900 D/PKGMGR_INFO(29937): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.251+0900 D/PKGMGR_INFO(29937): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.251+0900 D/PKGMGR_INFO(29937): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.251+0900 D/PKGMGR_INFO(29937): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.271+0900 D/PKGMGR_INFO(29937): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.271+0900 D/PKGMGR_INFO(29937): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.341+0900 D/AUL     (29958): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
03-18 00:27:54.341+0900 D/AUL     (29958): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-18 00:27:54.341+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 00:27:54.341+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(540) > launch a single-instance appid: org.tizen.crash-popup
03-18 00:27:54.341+0900 D/AUL     ( 2100): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2068, pid = 29958
03-18 00:27:54.341+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-18 00:27:54.341+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1785) > process_pool: false
03-18 00:27:54.341+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 00:27:54.341+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.tizen.crash-popup
03-18 00:27:54.341+0900 D/AUL_AMD ( 2100): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 00:27:54.341+0900 D/AUL     ( 2100): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 00:27:54.341+0900 D/AUL_PAD ( 2106): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
03-18 00:27:54.341+0900 D/AUL_PAD ( 2106): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 00:27:54.341+0900 D/AUL_PAD ( 2106): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 29959 /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-18 00:27:54.341+0900 D/AUL_PAD ( 2106): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 00:27:54.341+0900 D/AUL_PAD (29959): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 00:27:54.341+0900 D/AUL_PAD (29959): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 00:27:54.341+0900 D/AUL_PAD (29959): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
03-18 00:27:54.351+0900 D/AUL_PAD (29959): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 00:27:54.351+0900 D/AUL_PAD (29959): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
03-18 00:27:54.351+0900 D/AUL_PAD (29959): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
03-18 00:27:54.351+0900 D/AUL_PAD (29959): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
03-18 00:27:54.351+0900 D/AUL_PAD (29959): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
03-18 00:27:54.351+0900 D/AUL_PAD (29959): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
03-18 00:27:54.351+0900 D/AUL_PAD (29959): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
03-18 00:27:54.351+0900 D/LAUNCH  (29959): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
03-18 00:27:54.361+0900 D/LAUNCH  (29959): appcore-efl.c: appcore_efl_main(1571) > [crash-popup:Application:main:done]
03-18 00:27:54.371+0900 D/APP_CORE(29959): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 00:27:54.371+0900 D/AUL     (29959): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 29959 is org.tizen.crash-popup
03-18 00:27:54.371+0900 D/APP_CORE(29959): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
03-18 00:27:54.371+0900 D/APP_CORE(29959): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 00:27:54.371+0900 D/AUL     (29959): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 00:27:54.371+0900 D/LAUNCH  (29959): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
03-18 00:27:54.381+0900 D/EFL-ASSIST(29959): efl_assist_theme.c: ea_theme_changeable_ui_enabled_set(267) > changeable state is set to 1
03-18 00:27:54.381+0900 D/EFL-ASSIST(29959): efl_assist_theme.c: _theme_color_monitor_add(239) > color config file (/opt/home/app/.elementary/config/wearable/color.cfg) monitor is added!!
03-18 00:27:54.381+0900 I/EFL-ASSIST(29959): efl_assist_theme.c: _theme_changeable_ui_data_set(220) > changeable state [1] is set to ecore_evas [b91ed7b8]
03-18 00:27:54.381+0900 D/EFL-ASSIST(29959): efl_assist_theme_color.c: ea_theme_style_set(951) > changeable state: 1,  winset style (0)
03-18 00:27:54.381+0900 I/EFL-ASSIST(29959): efl_assist_theme_color.c: _color_config_get(215) > read color config file from (/opt/home/app/.elementary/config/wearable/color.cfg)
03-18 00:27:54.381+0900 I/EFL-ASSIST(29959): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (b920cc20) from (/usr/share/themes/ChangeableColorTable1.xml) is created
03-18 00:27:54.381+0900 I/EFL-ASSIST(29959): efl_assist_theme_color.c: ea_theme_color_table_free(766) > color table (b920cc20) is freed
03-18 00:27:54.381+0900 I/EFL-ASSIST(29959): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (0) from (system-color.xml) is created
03-18 00:27:54.381+0900 I/EFL-ASSIST(29959): efl_assist_theme_font.c: ea_theme_font_table_new(381) > font table (0) from (system-font.xml) is created
03-18 00:27:54.381+0900 D/APP_CORE(29959): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 00:27:54.381+0900 D/LAUNCH  (29959): appcore-efl.c: __before_loop(1047) > [crash-popup:Application:create:done]
03-18 00:27:54.381+0900 D/APP_CORE(29959): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-18 00:27:54.381+0900 D/APP_CORE(29959): appcore.c: __aul_handler(423) > [APP 29959]     AUL event: AUL_START
03-18 00:27:54.381+0900 D/APP_CORE(29959): appcore-efl.c: __do_app(470) > [APP 29959] Event: RESET State: CREATED
03-18 00:27:54.381+0900 D/APP_CORE(29959): appcore-efl.c: __do_app(496) > [APP 29959] RESET
03-18 00:27:54.381+0900 D/LAUNCH  (29959): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
03-18 00:27:54.381+0900 D/CRASH_POPUP(29959): crash.c: app_reset(226) > bundle_get_val - process_name:flyingbird
03-18 00:27:54.381+0900 D/CRASH_POPUP(29959): crash.c: app_reset(234) > bundle_get_val - exepath:/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
03-18 00:27:54.381+0900 D/PKGMGR_INFO(29959): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.381+0900 D/PKGMGR_INFO(29959): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.381+0900 D/PKGMGR_INFO(29959): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.381+0900 D/PKGMGR_INFO(29959): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
03-18 00:27:54.381+0900 I/CRASH_POPUP(29959): crash.c: load_crash_process_popup(117) > Popup content: Flying Bird has closed unexpectedly.
03-18 00:27:54.421+0900 E/EFL     (29959): eina_module<29959> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 00:27:54.431+0900 W/W_HOME  ( 2221): dbus.c: _dbus_message_recv_cb(178) > LCD on
03-18 00:27:54.431+0900 W/W_HOME  ( 2221): main.c: _lcd_on_cb(951) > LCD: off->on
03-18 00:27:54.441+0900 D/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
03-18 00:27:54.441+0900 W/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
03-18 00:27:54.441+0900 D/LAUNCH  (29959): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
03-18 00:27:54.441+0900 I/APP_CORE(29959): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-18 00:27:54.441+0900 I/APP_CORE(29959): appcore-efl.c: __do_app(509) > [APP 29959] Initial Launching, call the resume_cb
03-18 00:27:54.441+0900 D/APP_CORE(29959): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: on_changed_receive(1246) > org.tizen.system.deviced.display - LCDOn
03-18 00:27:54.441+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-18 00:27:54.441+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-18 00:27:54.441+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(clock_font_color) error
03-18 00:27:54.441+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-18 00:27:54.441+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-18 00:27:54.441+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(showdate) error
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Fri 18 Mar][1458228474]
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(857) > 
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458228474]
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(5)[12:27][1458228474]
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(871) > utc_time=12:27, utc_ampm=[2]AM
03-18 00:27:54.441+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>12:27<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-18 00:27:54.441+0900 D/APP_CORE(29959): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00006
03-18 00:27:54.441+0900 D/APP_CORE(29959): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1e00006
03-18 00:27:54.451+0900 D/AUL_PAD ( 2106): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-18 00:27:54.451+0900 D/AUL_PAD ( 2106): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-18 00:27:54.451+0900 D/AUL_PAD ( 2106): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-18 00:27:54.451+0900 D/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 00:27:54.451+0900 E/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 00:27:54.451+0900 E/AUL_AMD ( 2100): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
03-18 00:27:54.451+0900 D/RESOURCED( 2344): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 00:27:54.451+0900 D/RESOURCED( 2344): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2100
03-18 00:27:54.451+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 29959, type 4 
03-18 00:27:54.451+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 29959
03-18 00:27:54.451+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
03-18 00:27:54.451+0900 E/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 339
03-18 00:27:54.451+0900 D/RESOURCED( 2344): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 00:27:54.451+0900 D/AUL     (29958): launch.c: app_request_to_launchpad(295) > launch request result : 29959
03-18 00:27:54.451+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-18 00:27:54.451+0900 D/W_HOME  ( 2221): clock_event.c: _display_state_cb(194) > LCD: off->on
03-18 00:27:54.451+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:40000 received
03-18 00:27:54.451+0900 D/W_HOME  ( 2221): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-18 00:27:54.451+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
03-18 00:27:54.451+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-18 00:27:54.451+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
03-18 00:27:54.451+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
03-18 00:27:54.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [0]
03-18 00:27:54.491+0900 D/APP_CORE(29959): appcore.c: __prt_ltime(183) > [APP 29959] first idle after reset: 150 msec
03-18 00:27:54.521+0900 D/AUL_AMD ( 2100): amd_launch.c: __e17_status_handler(1911) > pid(29959) status(3)
03-18 00:27:54.521+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 29959, type = 0
03-18 00:27:54.521+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 29959
03-18 00:27:54.521+0900 I/RESOURCED( 2344): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 29959, oom : 200
03-18 00:27:54.521+0900 E/RESOURCED( 2344): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-18 00:27:54.521+0900 E/RESOURCED( 2344): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (29959) didn't have any process list
03-18 00:27:54.521+0900 D/RESOURCED( 2344): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 29959, appname = (null)
03-18 00:27:54.521+0900 D/RESOURCED( 2344): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 29959
03-18 00:27:54.521+0900 D/APP_CORE(29959): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1e00006 fully_obscured 0
03-18 00:27:54.521+0900 D/APP_CORE(29959): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-18 00:27:54.521+0900 D/APP_CORE(29959): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-18 00:27:54.521+0900 D/APP_CORE(29959): appcore-efl.c: __do_app(470) > [APP 29959] Event: RESUME State: RUNNING
03-18 00:27:54.521+0900 D/LAUNCH  (29959): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
03-18 00:27:54.521+0900 D/LAUNCH  (29959): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
03-18 00:27:54.521+0900 D/LAUNCH  (29959): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
03-18 00:27:54.521+0900 D/APP_CORE(29959): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-18 00:27:54.521+0900 E/APP_CORE(29959): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-18 00:27:55.461+0900 D/AUL_AMD ( 2100): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-18 00:27:55.461+0900 D/RUA     ( 2100): rua.c: rua_add_history(179) > rua_add_history start
03-18 00:27:55.461+0900 D/RUA     ( 2100): rua.c: rua_add_history(247) > rua_add_history ok
03-18 00:27:55.521+0900 I/GESTURE ( 1996): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 00:27:55.571+0900 D/EFL     (29959): ecore_x<29959> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=103239562 button=1
03-18 00:27:55.591+0900 D/EFL     (29959): ecore_x<29959> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=103239605 button=1
03-18 00:27:55.591+0900 E/EFL     (29959): eina_module<29959> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 00:27:55.601+0900 D/AUL     (29959): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
03-18 00:27:55.601+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(495) > __request_handler: 22
03-18 00:27:55.601+0900 D/APP_CORE(29959): appcore-efl.c: __after_loop(1062) > [APP 29959] PAUSE before termination
03-18 00:27:55.621+0900 I/AUL_PAD ( 2106): sigchild.h: __launchpad_sig_child(142) > dead_pid = 29959 pgid = 29959
03-18 00:27:55.621+0900 I/AUL_PAD ( 2106): sigchild.h: __sigchild_action(123) > dead_pid(29959)
03-18 00:27:55.621+0900 D/AUL_PAD ( 2106): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-18 00:27:55.621+0900 I/AUL_PAD ( 2106): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-18 00:27:55.621+0900 I/AUL_PAD ( 2106): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-18 00:27:55.621+0900 I/AUL_AMD ( 2100): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29959
03-18 00:27:55.621+0900 D/AUL_AMD ( 2100): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 00:27:55.621+0900 D/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 00:27:55.621+0900 E/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 00:27:55.621+0900 D/W_HOME  ( 2221): main.c: _dead_cb(542) > PID(29959) is dead
03-18 00:27:55.621+0900 E/W_HOME  ( 2221): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 00:27:55.621+0900 D/STARTER ( 2215): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 29959)
03-18 00:27:56.991+0900 D/W_HOME  ( 2221): main.c: _window_focus_in_cb(848) > focus in
03-18 00:27:56.991+0900 D/W_HOME  ( 2221): main.c: _resume_cb(564) > Resumed
03-18 00:27:56.991+0900 D/APPS    ( 2221): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
03-18 00:27:56.991+0900 D/W_HOME  ( 2221): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
03-18 00:27:56.991+0900 E/efl-extension( 2221): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb931f320, elm_scroller, _activated_obj : 0xb931f320, activated : 1
03-18 00:27:56.991+0900 W/W_HOME  ( 2221): main.c: _resume_cb(589) > clock/widget resumed
03-18 00:27:56.991+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10004 received
03-18 00:27:56.991+0900 D/W_HOME  ( 2221): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-18 00:27:56.991+0900 D/W_HOME  ( 2221): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb939c8a0 is resumed
03-18 00:27:56.991+0900 E/APPS    ( 2221): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
03-18 00:27:56.991+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=10
03-18 00:27:56.991+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_resume
03-18 00:27:56.991+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1291) > ##### mc_resume
03-18 00:27:57.001+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2221 is resumed
03-18 00:27:57.001+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-18 00:27:57.611+0900 D/AUL_AMD ( 2100): amd_status.c: __app_terminate_timer_cb(113) > pid(29959)
03-18 00:27:57.611+0900 D/AUL_AMD ( 2100): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-18 00:28:00.481+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-18 00:28:00.481+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-18 00:28:00.481+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(clock_font_color) error
03-18 00:28:00.481+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-18 00:28:00.481+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-18 00:28:00.481+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(showdate) error
03-18 00:28:00.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-18 00:28:00.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Fri 18 Mar][1458228480]
03-18 00:28:00.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(857) > 
03-18 00:28:00.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458228480]
03-18 00:28:00.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(5)[12:28][1458228480]
03-18 00:28:00.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(871) > utc_time=12:28, utc_ampm=[2]AM
03-18 00:28:00.481+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>12:28<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: main(1436) > server start
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: main(1505) > Main loop is created.
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(144) > called
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(155) > done
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkg_mgr_object_init(93) > called
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > RequestName returns: 1
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkg_mgr_object_init(135) > Ready to serve requests
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkg_mgr_object_init(139) > done
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: main(1510) > pkg_mgr object is created, and request callback is registered.
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkgmgr_request(194) > Called
03-18 00:28:00.631+0900 D/PKGMGR  (30023): comm_pkg_mgr_server.c: pkgmgr_request(203) > [SECURE_LOG] Call request callback(obj, org.exelim.flyingbird_1184278983, 11, rpm, org.exelim.flyingbird, , *ret)
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: req_cb(431) > [SECURE_LOG] >> in callback >> Got request: [org.exelim.flyingbird_1184278983] [11] [rpm] [org.exelim.flyingbird] [] []
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: __register_signal_handler(382) > signal: SIGCHLD succeed
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: __register_signal_handler(384) > g_timeout_add_seconds() Added to Main Loop
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: req_cb(450) > req_type=(11)  backend_flag=(0)
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: queue_job(1168) > saved queue status. Now try fork()
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: queue_job(1175) > child forked [30024] for request type [11]
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: queue_job(1347) > parent exit
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30024): pkgmgr-server.c: queue_job(1175) > child forked [0] for request type [11]
03-18 00:28:00.631+0900 D/PKGMGR_SERVER(30024): pkgmgr-server.c: __make_pid_info_file(825) > File path = /tmp/org.exelim.flyingbird
03-18 00:28:00.661+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: sighandler(326) > child exit [30024]
03-18 00:28:00.661+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: sighandler(341) > child NORMAL exit [30024]
03-18 00:28:02.531+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [1]
03-18 00:28:02.531+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1108) > Not interested PM STATE
03-18 00:28:02.531+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-18 00:28:02.531+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 2[0;m
03-18 00:28:02.531+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-18 00:28:02.991+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: exit_server(724) > exit_server Start
03-18 00:28:02.991+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: main(1516) > Quit main loop.
03-18 00:28:02.991+0900 D/PKGMGR_SERVER(30023): pkgmgr-server.c: main(1524) > package manager server terminated.
03-18 00:28:03.801+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 00:28:03.801+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(540) > launch a single-instance appid: org.exelim.flyingbird
03-18 00:28:03.801+0900 D/AUL     ( 2100): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 30078, pid = 30080
03-18 00:28:03.811+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-18 00:28:03.811+0900 D/AUL_AMD ( 2100): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 00:28:03.811+0900 D/AUL     ( 2100): app_sock.c: __app_send_raw(265) > pid(-4) : cmd(0)
03-18 00:28:03.911+0900 E/AUL_PAD ( 2122): launchpad.c: __launchpad_main_loop(1177) > faild to get app pid
03-18 00:28:03.911+0900 D/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 00:28:03.911+0900 E/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 00:28:03.911+0900 D/RESOURCED( 2344): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 00:28:03.911+0900 D/RESOURCED( 2344): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2100
03-18 00:28:03.911+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.exelim.flyingbird, pid 30081, type 4 
03-18 00:28:03.911+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.exelim.flyingbird, 30081
03-18 00:28:03.911+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.exelim.flyingbird with pkgname
03-18 00:28:03.911+0900 E/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 347
03-18 00:28:03.911+0900 D/RESOURCED( 2344): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 00:28:04.901+0900 D/AUL_AMD ( 2100): amd_launch.c: __grab_timeout_handler(1212) > pid(30081) ecore_x_pointer_ungrab
03-18 00:28:04.901+0900 D/AUL_AMD ( 2100): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.exelim.flyingbird /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
03-18 00:28:04.901+0900 D/RUA     ( 2100): rua.c: rua_add_history(179) > rua_add_history start
03-18 00:28:04.911+0900 D/RUA     ( 2100): rua.c: rua_add_history(247) > rua_add_history ok
03-18 00:28:04.941+0900 I/efl-extension(30083): efl_extension.c: eext_mod_init(39) > Init
03-18 00:28:04.941+0900 D/AUL     (30083): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 30083 is org.exelim.flyingbird
03-18 00:28:04.941+0900 I/CAPI_APPFW_APPLICATION(30083): app_main.c: ui_app_main(701) > app_efl_main
03-18 00:28:04.941+0900 D/LAUNCH  (30083): appcore-efl.c: appcore_efl_main(1571) > [flyingbird:Application:main:done]
03-18 00:28:04.941+0900 D/AUL     (30083): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 30083 is org.exelim.flyingbird
03-18 00:28:05.091+0900 D/APP_CORE(30083): appcore-efl.c: __before_loop(1012) > elm_config_preferred_engine_set : opengl_x11
03-18 00:28:05.091+0900 D/AUL     (30083): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 30083 is org.exelim.flyingbird
03-18 00:28:05.091+0900 D/APP_CORE(30083): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.exelim.flyingbird/res/locale
03-18 00:28:05.091+0900 D/APP_CORE(30083): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 00:28:05.091+0900 D/AUL     (30083): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 00:28:05.091+0900 D/LAUNCH  (30083): appcore-efl.c: __before_loop(1035) > [flyingbird:Platform:appcore_init:done]
03-18 00:28:05.091+0900 I/CAPI_APPFW_APPLICATION(30083): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 00:28:05.521+0900 W/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(463) > [_notify_pm_lcdoff_cb:463] LCD OFF by lcd off source[2], wake_up_setting[1], ALPM_clock_state[0]
03-18 00:28:05.521+0900 E/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(482) > [_notify_pm_lcdoff_cb:482] Failed to get [memory/setup_wizard/state]
03-18 00:28:05.521+0900 W/STARTER ( 2215): clock-mgr.c: _check_reserved_popup_status(93) > [_check_reserved_popup_status:93] Current reserved apps status : 0
03-18 00:28:05.521+0900 W/STARTER ( 2215): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
03-18 00:28:05.521+0900 E/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(666) > [_notify_pm_lcdoff_cb:666] Failed to get VCONFKEY_SETTING_SIMPLE_CLOCK_MODE
03-18 00:28:05.521+0900 W/STARTER ( 2215): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
03-18 00:28:05.521+0900 W/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(674) > [_notify_pm_lcdoff_cb:674] Not reserved apss status AND wake_up_setting is CLOCK => show simple clock..!!
03-18 00:28:05.521+0900 E/STARTER ( 2215): dbus-util_w.c: _dbus_message_send(149) > [_dbus_message_send:149] dbus_message_new_signal(/Org/Tizen/Coreapps/starter:org.tizen.coreapps.starter.alpmclock-show)
03-18 00:28:05.521+0900 D/STARTER ( 2215): dbus-util_w.c: _dbus_message_send(163) > [_dbus_message_send:163] dbus_connection_send, ret=1
03-18 00:28:05.521+0900 E/STARTER ( 2215): dbus-util_w.c: starter_dbus_alpm_clock_signal_send(187) > [starter_dbus_alpm_clock_signal_send:187] Sending alpmclock show signal, result:0
03-18 00:28:05.521+0900 E/AUL_AMD ( 2100): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
03-18 00:28:05.521+0900 W/W_HOME  ( 2221): dbus.c: _dbus_message_recv_cb(190) > LCD on
03-18 00:28:05.521+0900 E/W_HOME  ( 2221): dbus.c: _dbus_message_recv_cb(197) > Failed to get reply (org.freedesktop.DBus.Error.InvalidArgs:Argument 0 is specified to be of type "string", but is actually of type "invalid"
03-18 00:28:05.521+0900 E/W_HOME  ( 2221): )
03-18 00:28:05.521+0900 D/W_HOME  ( 2221): main.c: _lcd_off_cb(967) > LCD: on->off
03-18 00:28:05.521+0900 W/W_HOME  ( 2221): main.c: _lcd_off_cb(970) > clock/widget paused
03-18 00:28:05.521+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-18 00:28:05.521+0900 D/W_HOME  ( 2221): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb939c8a0 is paused
03-18 00:28:05.521+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
03-18 00:28:05.521+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
03-18 00:28:05.521+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
03-18 00:28:05.521+0900 D/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
03-18 00:28:05.521+0900 W/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(632) > [_on_lcd_changed_receive:632] LCD off
03-18 00:28:05.531+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2221 is paused
03-18 00:28:05.531+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-18 00:28:05.581+0900 D/W_HOME  ( 2221): main.c: _window_focus_out_cb(869) > focus out
03-18 00:28:05.581+0900 D/W_HOME  ( 2221): main.c: _pause_cb(600) > Paused
03-18 00:28:05.581+0900 D/W_HOME  ( 2221): page.c: page_focus(701) > focus set to 0xb94374f8
03-18 00:28:05.581+0900 W/W_HOME  ( 2221): main.c: _pause_cb(613) > clock/widget paused
03-18 00:28:05.581+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-18 00:28:05.581+0900 E/APPS    ( 2221): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
03-18 00:28:05.591+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2221 is paused
03-18 00:28:05.591+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-18 00:28:05.591+0900 D/LAUNCH  (30083): appcore-efl.c: __before_loop(1047) > [flyingbird:Application:create:done]
03-18 00:28:05.591+0900 D/APP_CORE(30083): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-18 00:28:05.591+0900 D/APP_CORE(30083): appcore.c: __aul_handler(423) > [APP 30083]     AUL event: AUL_START
03-18 00:28:05.591+0900 D/APP_CORE(30083): appcore-efl.c: __do_app(470) > [APP 30083] Event: RESET State: CREATED
03-18 00:28:05.591+0900 D/APP_CORE(30083): appcore-efl.c: __do_app(496) > [APP 30083] RESET
03-18 00:28:05.591+0900 D/LAUNCH  (30083): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
03-18 00:28:05.591+0900 I/CAPI_APPFW_APPLICATION(30083): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-18 00:28:05.591+0900 D/APP_SVC (30083): appsvc.c: __set_bundle(161) > __set_bundle
03-18 00:28:05.591+0900 D/LAUNCH  (30083): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
03-18 00:28:05.591+0900 E/PKGMGR_INFO(30083): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1327) > (appid == NULL) appid is NULL
03-18 00:28:05.591+0900 I/APP_CORE(30083): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-18 00:28:05.591+0900 I/APP_CORE(30083): appcore-efl.c: __do_app(509) > [APP 30083] Initial Launching, call the resume_cb
03-18 00:28:05.591+0900 I/CAPI_APPFW_APPLICATION(30083): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-18 00:28:05.591+0900 D/APP_CORE(30083): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-18 00:28:05.591+0900 D/APP_CORE(30083): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00003
03-18 00:28:05.591+0900 D/APP_CORE(30083): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1a00003
03-18 00:28:05.601+0900 D/AUL     (30083): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 30083 is org.exelim.flyingbird
03-18 00:28:05.631+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [2]
03-18 00:28:05.631+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-18 00:28:05.631+0900 D/W_HOME  ( 2221): clock_event.c: _display_state_cb(197) > LCD: on->off
03-18 00:28:05.631+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:40001 received
03-18 00:28:05.631+0900 D/W_HOME  ( 2221): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:0, is_need_vi:0
03-18 00:28:05.631+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 3[0;m
03-18 00:28:05.631+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-18 00:28:05.631+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:3,lock_state:0[0;m
03-18 00:28:06.141+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(484) > [0;35mpolling disabled[0;m
03-18 00:28:09.531+0900 W/CRASH_MANAGER(29937): worker.c: worker_job(1189) > 1130083666c79145822848
