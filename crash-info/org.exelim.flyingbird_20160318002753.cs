S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20150902.2338
Build-Date: 2015.09.02 23:38:00

Crash Information
Process Name: flyingbird
PID: 29933
Date: 2016-03-18 00:27:53+0900
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
eax = 0x8019cd10, ebx = 0x800151d4
ecx = 0x00000008, edx = 0x42340000
eip = 0x8000d2f6

Memory Information
MemTotal:      124 KB
MemFree:        47 KB
Buffers:        12 KB
Cached:     155444 KB
VmPeak:      66368 KB
VmSize:      66368 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16792 KB
VmRSS:       16792 KB
VmData:       5904 KB
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

Callstack Information (PID:29933)
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
s_each_plugin(830) > [SECURE_LOG] PLUGIN_PRE_PROCESS : [shortcut-list] result=[0]
03-18 00:27:41.371+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(841) > [SECURE_LOG] PLUGIN_POST_PROCESS : [shortcut-list] result=[0]
03-18 00:27:41.371+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(830) > [SECURE_LOG] PLUGIN_PRE_PROCESS : [widget] result=[0]
03-18 00:27:41.371+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(841) > [SECURE_LOG] PLUGIN_POST_PROCESS : [widget] result=[0]
03-18 00:27:41.371+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.371+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(830) > [SECURE_LOG] PLUGIN_PRE_PROCESS : [notifications] result=[0]
03-18 00:27:41.371+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(841) > [SECURE_LOG] PLUGIN_POST_PROCESS : [notifications] result=[0]
03-18 00:27:41.371+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(830) > [SECURE_LOG] PLUGIN_PRE_PROCESS : [privileges] result=[-1]
03-18 00:27:41.371+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(841) > [SECURE_LOG] PLUGIN_POST_PROCESS : [privileges] result=[-1]
03-18 00:27:41.371+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(830) > [SECURE_LOG] PLUGIN_PRE_PROCESS : [http://tizen.org/category/downloadable_font] result=[-1]
03-18 00:27:41.381+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(841) > [SECURE_LOG] PLUGIN_POST_PROCESS : [http://tizen.org/category/downloadable_font] result=[-1]
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 E/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
03-18 00:27:41.381+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(830) > [SECURE_LOG] PLUGIN_PRE_PROCESS : [watch-application] result=[0]
03-18 00:27:41.381+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_each_plugin(841) > [SECURE_LOG] PLUGIN_POST_PROCESS : [watch-application] result=[0]
03-18 00:27:41.391+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_plugin_db(801) > [SECURE_LOG] pkgid [org.exelim.flyingbird] plugin[0x0] deleted
03-18 00:27:41.391+0900 D/PKGMGR_PLUGIN(29868): pkgmgr_parser_plugin.c: __process_plugin_db(817) > [SECURE_LOG] pkgid [org.exelim.flyingbird] plugin[0x0] inserted
03-18 00:27:41.391+0900 D/AIL     (29868): ail_filter.c: ail_filter_count_appinfo(306) > No filter exists. All records are retreived
03-18 00:27:41.391+0900 E/AIL     (29868): ail_db.c: db_exec(244) > Cannot execute because table app_info already exists
03-18 00:27:41.391+0900 E/AIL     (29868): ail_db.c: db_exec(245) > query - CREATE TABLE app_info (package TEXT PRIMARY KEY, exec TEXT DEFAULT 'No Exec', name TEXT DEFAULT 'No Name', type TEXT DEFAULT 'Application', icon TEXT DEFAULT 'No Icon', categories TEXT, version TEXT, mimetype TEXT, x_slp_service TEXT, x_slp_packagetype TEXT, x_slp_packagecategories TEXT, x_slp_packageid TEXT, x_slp_uri TEXT, x_slp_svc TEXT, x_slp_exe_path TEXT, x_slp_appid TEXT, x_slp_pkgid TEXT, x_slp_domain TEXT, x_slp_submodemainid TEXT, x_slp_installedstorage TEXT, x_slp_baselayoutwidth INTEGER DEFAULT 0, x_slp_installedtime INTEGER DEFAULT 0, nodisplay INTEGER DEFAULT 0, x_slp_taskmanage INTEGER DEFAULT 1, x_slp_multiple INTEGER DEFAULT 0, x_slp_removable INTEGER DEFAULT 1, x_slp_ishorizontalscale INTEGER DEFAULT 0, x_slp_enabled INTEGER DEFAULT 1, x_slp_submode INTEGER DEFAULT 0, desktop TEXT UNIQUE NOT NULL);
03-18 00:27:41.391+0900 E/AIL     (29868): ail_desktop.c: _create_table(1200) > (ret != AIL_ERROR_OK) -> _create_table() return
03-18 00:27:41.391+0900 D/AIL     (29868): ail_desktop.c: ail_desktop_add(1595) > Cannot create a table. Maybe there is already a table.
03-18 00:27:41.391+0900 D/AIL     (29868): ail_desktop.c: _read_desktop_info(967) > Read (org.exelim.flyingbird).
03-18 00:27:41.391+0900 D/AIL     (29868): ail_desktop.c: _insert_desktop_info(1314) > Add (org.exelim.flyingbird).
03-18 00:27:41.401+0900 D/AIL     (29868): ail_desktop.c: _send_db_done_noti(1518) > Noti : create:org.exelim.flyingbird
03-18 00:27:41.401+0900 D/PKGMGR_PARSER(29868): pkgmgr_parser.c: pkgmgr_parser_parse_manifest_for_installation(2219) > Creating desktop file Success
03-18 00:27:41.401+0900 D/PKGMGR_PARSER(29868): pkgmgr_parser.c: pkgmgr_parser_parse_manifest_for_installation(2224) > Free Done
03-18 00:27:41.401+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_package_install(2212) > manifest parsing done successfully.
03-18 00:27:41.401+0900 D/rpm-installer(29868): rpm-vconf-intf.c: _ri_broadcast_status_notification(188) > pkgid=[org.exelim.flyingbird], key=[install_percent], val=[60]
03-18 00:27:41.401+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2220): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[60]
03-18 00:27:41.401+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.401+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.401+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2366): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[60]
03-18 00:27:41.401+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.401+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.401+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2243): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[60]
03-18 00:27:41.401+0900 D/DATA_PROVIDER_MASTER( 2243): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.exelim.flyingbird] 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.401+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.401+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2244): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[60]
03-18 00:27:41.401+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.401+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[60]
03-18 00:27:41.401+0900 D/ADD_VIEWER( 2221): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.exelim.flyingbird] 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[60]
03-18 00:27:41.401+0900 D/W_HOME  ( 2221): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.exelim.flyingbird key:install_percent val:60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[60]
03-18 00:27:41.401+0900 D/APPS    ( 2221): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.exelim.flyingbird
03-18 00:27:41.401+0900 D/APPS    ( 2221): pkgmgr.c: _install_percent(469) >  package(org.exelim.flyingbird) with 60
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.401+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 1
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 1
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 1
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 1
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 1
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 1
03-18 00:27:41.401+0900 E/PKGMGR_CERT(29868): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1150) > skip! empty dirpath=[/usr/apps/org.exelim.flyingbird/lib]
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_make_directory(1517) > mkdir failed. appdir=[/usr/apps/org.exelim.flyingbird/shared], errno=[2][No such file or directory]
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1150) > skip! empty dirpath=[/usr/apps/org.exelim.flyingbird/shared]
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1150) > skip! empty dirpath=[/usr/apps/org.exelim.flyingbird/shared/res]
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/apps/org.exelim.flyingbird/tizen-manifest.xml]
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/apps/org.exelim.flyingbird/author-signature.xml]
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/apps/org.exelim.flyingbird/signature1.xml]
03-18 00:27:41.401+0900 E/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_file_policy(1135) > skip! empty filepath=[/usr/share/packages/org.exelim.flyingbird.xml]
03-18 00:27:41.401+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1321) > Exist shared/data folder (path:[/opt/usr/apps/org.exelim.flyingbird/shared/data])
03-18 00:27:41.411+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.exelim.flyingbird), result=[0]
03-18 00:27:41.411+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird, 5, _), result=[0]
03-18 00:27:41.411+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/shared, 5, _), result=[0]
03-18 00:27:41.411+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/shared/res, 5, _), result=[0]
03-18 00:27:41.431+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/shared/data, 2), result=[0]
03-18 00:27:41.431+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_get_group_id(1797) > encoding done, len=[28]
03-18 00:27:41.431+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_apply_smack(1905) > groupid = [xnu1Oa8utFewbE4MlvFi#95orWA=] for shared/trusted.
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/shared/trusted, 1, xnu1Oa8utFewbE4MlvFi#95orWA=), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/bin, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/data, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/res, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/cache, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/tizen-manifest.xml, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/author-signature.xml, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/usr/apps/org.exelim.flyingbird/signature1.xml, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/share/packages/org.exelim.flyingbird.xml, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/storage/sdcard/apps/org.exelim.flyingbird, 5, _), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/storage/sdcard/apps/org.exelim.flyingbird/data, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/storage/sdcard/apps/org.exelim.flyingbird/cache, 0, org.exelim.flyingbird), result=[0]
03-18 00:27:41.561+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.exelim.flyingbird, /opt/storage/sdcard/apps/org.exelim.flyingbird/shared, 5, _), result=[0]
03-18 00:27:41.571+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.exelim.flyingbird, /opt/storage/sdcard/apps/org.exelim.flyingbird/shared/data, 2), result=[0]
03-18 00:27:41.571+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_get_pkgfile_info(1010) > switched to /opt/usr/rpminstaller
03-18 00:27:41.571+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_load_directory(869) > loading manifest files, directory=[/opt/usr/rpminstaller]
03-18 00:27:41.571+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_load_directory(889) > manifest=[tizen-manifest.xml], path=[/opt/usr/rpminstaller/tizen-manifest.xml]
03-18 00:27:41.571+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_get_pkgfile_info(1032) > manifest file=[/opt/usr/rpminstaller/tizen-manifest.xml]
03-18 00:27:41.571+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_get_pkgfile_info(1066) > pkgid=[org.exelim.flyingbird], version=[1.0.1], api-version=[2.3.1]
03-18 00:27:41.571+0900 E/rpm-installer(29868): coretpk-parser.c: _coretpk_parser_is_widget(773) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
03-18 00:27:41.571+0900 D/rpm-installer(29868): rpm-installer-util.c: _rpm_delete_dir(261) > delete_dir=[/opt/usr/rpminstaller]
03-18 00:27:41.581+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.exelim.flyingbird] version set to [2.3.1] result=[0]
03-18 00:27:41.581+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_package_install(2249) > api-version fot privilege has done successfully.
03-18 00:27:41.581+0900 D/rpm-installer(29868): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-18 00:27:41.581+0900 D/rpm-installer(29868): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.exelim.flyingbird, 7), result=[0]
03-18 00:27:41.591+0900 D/rpm-installer(29868): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-18 00:27:41.591+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_package_install(2259) > permission applying done successfully.
03-18 00:27:41.591+0900 D/rpm-installer(29868): rpm-vconf-intf.c: _ri_broadcast_status_notification(188) > pkgid=[org.exelim.flyingbird], key=[install_percent], val=[100]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[100]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[100]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[100]
03-18 00:27:41.591+0900 D/DATA_PROVIDER_MASTER( 2243): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.exelim.flyingbird] 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[100]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[100]
03-18 00:27:41.591+0900 D/ADD_VIEWER( 2221): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.exelim.flyingbird] 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[100]
03-18 00:27:41.591+0900 D/W_HOME  ( 2221): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.exelim.flyingbird key:install_percent val:100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / install_percent / 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[install_percent] val[100]
03-18 00:27:41.591+0900 D/APPS    ( 2221): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.exelim.flyingbird
03-18 00:27:41.591+0900 D/APPS    ( 2221): pkgmgr.c: _install_percent(469) >  package(org.exelim.flyingbird) with 100
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_package_install(2289) > install status is [2].
03-18 00:27:41.591+0900 D/rpm-installer(29868): coretpk-installer.c: __post_install_for_mmc(311) > Installed storage is internal.
03-18 00:27:41.591+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_package_install(2301) > _coretpk_installer_package_install is done.
03-18 00:27:41.591+0900 D/rpm-installer(29868): rpm-vconf-intf.c: _ri_broadcast_status_notification(196) > pkgid=[org.exelim.flyingbird], key=[end], val=[ok]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2220): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2244): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/DATA_PROVIDER_MASTER( 2243): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.exelim.flyingbird] ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2243): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/ADD_VIEWER( 2221): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.exelim.flyingbird] ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/W_HOME  ( 2221): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.exelim.flyingbird key:end val:ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2221): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/APPS    ( 2221): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.exelim.flyingbird
03-18 00:27:41.591+0900 D/APPS    ( 2221): pkgmgr.c: _end(651) >  Package(org.exelim.flyingbird) : key(update) - val(ok)
03-18 00:27:41.591+0900 D/APPS    ( 2221): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.exelim.flyingbird]
03-18 00:27:41.591+0900 D/APPS    ( 2221): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.exelim.flyingbird]'s item object
03-18 00:27:41.591+0900 D/APPS    ( 2221): db.c: apps_db_remove_item(404) >  Remove the item[org.exelim.flyingbird]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.591+0900 D/PKGMGR  ( 2366): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.591+0900 D/PKGMGR  ( 2100): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836 / coretpk / org.exelim.flyingbird / end / ok
03-18 00:27:41.591+0900 D/PKGMGR  ( 2100): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.exelim.flyingbird-1.0.1-i386.tpk_1164730836] pkg_type[coretpk] pkgid[org.exelim.flyingbird]key[end] val[ok]
03-18 00:27:41.591+0900 D/AUL_AMD ( 2100): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.exelim.flyingbird), key(end), value(ok)
03-18 00:27:41.591+0900 D/AUL_AMD ( 2100): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
03-18 00:27:41.601+0900 D/AUL_AMD ( 2100): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-18 00:27:41.601+0900 D/AUL_AMD ( 2100): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.exelim.flyingbird, comp:ui, type:rpm
03-18 00:27:41.601+0900 D/PKGMGR  ( 2100): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.601+0900 D/PKGMGR  ( 2100): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.601+0900 D/rpm-installer(29868): coretpk-installer.c: _coretpk_installer_prepare_package_install(2777) > success
03-18 00:27:41.601+0900 D/rpm-installer(29868): rpm-appcore-intf.c: main(224) > sync() start
03-18 00:27:41.601+0900 D/APPS    ( 2221): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.exelim.flyingbird], name[Flying Bird]
03-18 00:27:41.601+0900 D/APPS    ( 2221): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.exelim.flyingbird]
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-18 00:27:41.601+0900 D/BADGE   ( 2243): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.exelim.flyingbird'], count[0]
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-18 00:27:41.601+0900 E/DATA_PROVIDER_MASTER( 2243): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-18 00:27:41.601+0900 D/COM_CORE( 2221): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2243, fd: -1
03-18 00:27:41.601+0900 D/COM_CORE( 2221): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2243), fd: -1
03-18 00:27:41.601+0900 D/COM_CORE( 2221): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 32 (recv_fd: -1)
03-18 00:27:41.601+0900 D/APPS    ( 2221): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.exelim.flyingbird]
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 99 bytes
03-18 00:27:41.601+0900 D/COM_CORE( 2243): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb94bd0a0 is terminated (NIL packet)
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-18 00:27:41.601+0900 D/BADGE   ( 2243): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.exelim.flyingbird'], count[0]
03-18 00:27:41.601+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-18 00:27:41.601+0900 E/DATA_PROVIDER_MASTER( 2243): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-18 00:27:41.601+0900 D/COM_CORE( 2221): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2243, fd: -1
03-18 00:27:41.601+0900 D/COM_CORE( 2221): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2243), fd: -1
03-18 00:27:41.601+0900 D/COM_CORE( 2221): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 32 (recv_fd: -1)
03-18 00:27:41.611+0900 D/APPS    ( 2221): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.exelim.flyingbird], name[Flying Bird]
03-18 00:27:41.611+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 99 bytes
03-18 00:27:41.611+0900 D/COM_CORE( 2243): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-18 00:27:41.611+0900 D/DATA_PROVIDER_MASTER( 2243): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb94bcfa0 is terminated (NIL packet)
03-18 00:27:41.611+0900 D/DATA_PROVIDER_MASTER( 2243): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-18 00:27:41.611+0900 D/APPS    ( 2221): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-18 00:27:41.611+0900 D/BADGE   ( 2221): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.exelim.flyingbird'], count[0]
03-18 00:27:41.611+0900 D/APPS    ( 2221): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-18 00:27:41.611+0900 D/APPS    ( 2221): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.glview11cube]'s ordering : 1
03-18 00:27:41.611+0900 D/APPS    ( 2221): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.exelim.flyingbird]'s ordering : 2
03-18 00:27:41.611+0900 D/APPS    ( 2221): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-18 00:27:41.621+0900 D/APPS    ( 2221): db.c: apps_db_update_item(374) >  Update the item[org.example.glview11cube:1]
03-18 00:27:41.621+0900 D/APPS    ( 2221): db.c: apps_db_insert_item(345) >  Insert the item[org.exelim.flyingbird:2]
03-18 00:27:41.621+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 00:27:41.621+0900 D/PKGMGR  ( 2221): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 00:27:41.641+0900 D/rpm-installer(29868): rpm-appcore-intf.c: main(226) > sync() end
03-18 00:27:41.641+0900 D/rpm-installer(29868): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-18 00:27:41.641+0900 D/rpm-installer(29868): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-18 00:27:41.641+0900 D/rpm-installer(29868): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-18 00:27:41.641+0900 D/PKGMGR_SERVER(29867): pkgmgr-server.c: sighandler(326) > child exit [29868]
03-18 00:27:41.641+0900 D/PKGMGR_SERVER(29867): pkgmgr-server.c: sighandler(341) > child NORMAL exit [29868]
03-18 00:27:42.991+0900 D/PKGMGR_SERVER(29867): pkgmgr-server.c: exit_server(724) > exit_server Start
03-18 00:27:42.991+0900 D/PKGMGR_SERVER(29867): pkgmgr-server.c: main(1516) > Quit main loop.
03-18 00:27:42.991+0900 D/PKGMGR_SERVER(29867): pkgmgr-server.c: main(1524) > package manager server terminated.
03-18 00:27:46.731+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 00:27:46.731+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(540) > launch a single-instance appid: org.exelim.flyingbird
03-18 00:27:46.731+0900 D/AUL     ( 2100): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 29928, pid = 29930
03-18 00:27:46.731+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-18 00:27:46.731+0900 D/AUL_AMD ( 2100): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 00:27:46.731+0900 D/AUL     ( 2100): app_sock.c: __app_send_raw(265) > pid(-4) : cmd(0)
03-18 00:27:46.841+0900 E/AUL_PAD ( 2122): launchpad.c: __launchpad_main_loop(1177) > faild to get app pid
03-18 00:27:46.841+0900 D/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 00:27:46.841+0900 E/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 00:27:46.841+0900 D/RESOURCED( 2344): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 00:27:46.841+0900 D/RESOURCED( 2344): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2100
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
03-18 00:27:53.391+0900 W/CRASH_MANAGER(29937): worker.c: worker_job(1189) > 1129933666c79145822847
