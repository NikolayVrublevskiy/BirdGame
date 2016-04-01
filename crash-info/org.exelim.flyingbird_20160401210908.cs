S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20150902.2338
Build-Date: 2015.09.02 23:38:00

Crash Information
Process Name: flyingbird
PID: 10648
Date: 2016-04-01 21:09:08+0900
Executable File Path: /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x72757478

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xffffffff, esi = 0x80178528
ebp = 0xbffff3d8, esp = 0xbffff3a0
eax = 0x72757478, ebx = 0x8001737c
ecx = 0x00000000, edx = 0x3f800000
eip = 0x80007258

Memory Information
MemTotal:      124 KB
MemFree:        51 KB
Buffers:         9 KB
Cached:     152912 KB
VmPeak:      64772 KB
VmSize:      64728 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14984 KB
VmRSS:       14956 KB
VmData:       4620 KB
VmStk:         136 KB
VmExe:          92 KB
VmLib:       32032 KB
VmPTE:          56 KB
VmSwap:          0 KB

Maps Information
80000000 80017000 r-xp /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
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

Callstack Information (PID:10648)
Call Stack Count: 21
 0: Object::Object(Object const&) + 0x1ac (0x80007258) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x7258
 1: Object::Clone() + 0x31 (0x800072ab) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x72ab
 2: Screen::Screen(Screen const&) + 0x47 (0x8000b6cb) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xb6cb
 3: Game::Init() + 0x68 (0x80005bce) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x5bce
 4: init_gl(_Evas_Object*) + 0x1f (0x8000e13b) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xe13b
 5: (0xb7e45307) [/usr/lib/libelementary.so.1] + 0xd6307
 6: (0xb472e42d) [/usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so] + 0xb42d
 7: (0xb7c581c1) [/usr/lib/libevas.so.1] + 0x2e1c1
 8: (0xb7ca5635) [/usr/lib/libevas.so.1] + 0x7b635
 9: (0xb7ca9305) [/usr/lib/libevas.so.1] + 0x7f305
10: (0xb73958d7) [/usr/lib/libecore_evas.so.1] + 0x158d7
11: ecore_evas_manual_render + 0x5d (0xb73905cd) [/usr/lib/libecore_evas.so.1] + 0x105cd
12: (0xb7394879) [/usr/lib/libecore_evas.so.1] + 0x14879
13: (0xb7fa7852) [/usr/lib/libecore.so.1] + 0xc852
14: (0xb7fa92fd) [/usr/lib/libecore.so.1] + 0xe2fd
15: ecore_main_loop_begin + 0x3f (0xb7fa99cf) [/usr/lib/libecore.so.1] + 0xe9cf
16: elm_run + 0x17 (0xb7e76867) [/usr/lib/libelementary.so.1] + 0x107867
17: appcore_efl_main + 0x3d1 (0xb793ee91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
18: ui_app_main + 0x130 (0xb7fd0500) [/usr/lib/libcapi-appfw-application.so.0] + 0x2500
19: main + 0xc8 (0x8000e97f) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xe97f
20: __libc_start_main + 0xf3 (0xb79be0f3) [/lib/libc.so.6] + 0x190f3
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
_before_loop(1047) > [flyingbird:Application:create:done]
04-01 21:07:07.850+0900 D/APP_CORE(10496): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
04-01 21:07:07.850+0900 D/APP_CORE(10496): appcore.c: __aul_handler(423) > [APP 10496]     AUL event: AUL_START
04-01 21:07:07.850+0900 D/APP_CORE(10496): appcore-efl.c: __do_app(470) > [APP 10496] Event: RESET State: CREATED
04-01 21:07:07.850+0900 D/APP_CORE(10496): appcore-efl.c: __do_app(496) > [APP 10496] RESET
04-01 21:07:07.850+0900 D/LAUNCH  (10496): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
04-01 21:07:07.850+0900 I/CAPI_APPFW_APPLICATION(10496): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
04-01 21:07:07.850+0900 D/APP_SVC (10496): appsvc.c: __set_bundle(161) > __set_bundle
04-01 21:07:07.850+0900 D/LAUNCH  (10496): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
04-01 21:07:07.850+0900 E/PKGMGR_INFO(10496): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1327) > (appid == NULL) appid is NULL
04-01 21:07:07.850+0900 I/APP_CORE(10496): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
04-01 21:07:07.850+0900 I/APP_CORE(10496): appcore-efl.c: __do_app(509) > [APP 10496] Initial Launching, call the resume_cb
04-01 21:07:07.850+0900 I/CAPI_APPFW_APPLICATION(10496): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
04-01 21:07:07.850+0900 D/APP_CORE(10496): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
04-01 21:07:07.850+0900 D/APP_CORE(10496): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00003
04-01 21:07:07.850+0900 D/APP_CORE(10496): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00003
04-01 21:07:11.620+0900 D/AUL     (10496): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 10496 is org.exelim.flyingbird
04-01 21:07:16.300+0900 E/RESOURCED( 2356): proc-monitor.c: edbus_signal_trigger(467) > [edbus_signal_trigger,467] Receive watchdog signal to pid: 10496(flyingbird)
04-01 21:07:17.850+0900 W/W_HOME  ( 2236): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
04-01 21:07:17.850+0900 D/APP_CORE( 2236): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
04-01 21:07:17.850+0900 D/APP_CORE( 2236): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
04-01 21:07:17.850+0900 D/APP_CORE( 2236): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
04-01 21:07:17.850+0900 D/APP_CORE( 2236): appcore-efl.c: __do_app(470) > [APP 2236] Event: PAUSE State: PAUSED
04-01 21:07:17.850+0900 D/APP_CORE( 2236): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
04-01 21:07:17.850+0900 E/APP_CORE( 2236): appcore-efl.c: __trm_app_info_send_socket(233) > access
04-01 21:07:17.860+0900 D/RESOURCED( 2356): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2236, type = 2
04-01 21:07:17.860+0900 D/AUL_AMD ( 2105): amd_launch.c: __e17_status_handler(1911) > pid(10496) status(3)
04-01 21:07:17.860+0900 D/RESOURCED( 2356): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 10496, type = 0
04-01 21:07:17.860+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 10496
04-01 21:07:17.860+0900 E/RESOURCED( 2356): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (10496) didn't have any process list
04-01 21:07:17.860+0900 D/RESOURCED( 2356): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 10496, appname = (null)
04-01 21:07:17.860+0900 D/RESOURCED( 2356): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10496
04-01 21:08:09.999+0900 W/CRASH_MANAGER(10500): worker.c: worker_job(1189) > 1110496666c791459512489
04-01 21:08:10.849+0900 D/PKGMGR_INFO(10500): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.849+0900 D/PKGMGR_INFO(10500): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.849+0900 D/PKGMGR_INFO(10500): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.849+0900 D/PKGMGR_INFO(10500): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.869+0900 D/PKGMGR_INFO(10500): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.869+0900 D/PKGMGR_INFO(10500): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.939+0900 D/AUL     (10521): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
04-01 21:08:10.939+0900 D/AUL     (10521): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
04-01 21:08:10.939+0900 D/AUL_AMD ( 2105): amd_request.c: __request_handler(495) > __request_handler: 0
04-01 21:08:10.939+0900 D/AUL_AMD ( 2105): amd_request.c: __request_handler(540) > launch a single-instance appid: org.tizen.crash-popup
04-01 21:08:10.939+0900 D/AUL     ( 2105): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2067, pid = 10521
04-01 21:08:10.939+0900 D/AUL_AMD ( 2105): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
04-01 21:08:10.939+0900 D/AUL_AMD ( 2105): amd_launch.c: _start_app(1785) > process_pool: false
04-01 21:08:10.939+0900 D/AUL_AMD ( 2105): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
04-01 21:08:10.939+0900 D/AUL_AMD ( 2105): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.tizen.crash-popup
04-01 21:08:10.939+0900 D/AUL_AMD ( 2105): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 21:08:10.939+0900 D/AUL     ( 2105): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
04-01 21:08:10.949+0900 D/AUL_PAD ( 2108): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
04-01 21:08:10.949+0900 D/AUL_PAD ( 2108): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
04-01 21:08:10.949+0900 D/AUL_PAD ( 2108): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 10522 /usr/apps/org.tizen.crash-popup/bin/crash-popup
04-01 21:08:10.949+0900 D/AUL_PAD ( 2108): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
04-01 21:08:10.949+0900 D/AUL_PAD (10522): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
04-01 21:08:10.949+0900 D/LAUNCH  (10522): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
04-01 21:08:10.959+0900 D/LAUNCH  (10522): appcore-efl.c: appcore_efl_main(1571) > [crash-popup:Application:main:done]
04-01 21:08:10.969+0900 D/APP_CORE(10522): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
04-01 21:08:10.969+0900 D/AUL     (10522): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 10522 is org.tizen.crash-popup
04-01 21:08:10.969+0900 D/APP_CORE(10522): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
04-01 21:08:10.969+0900 D/APP_CORE(10522): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
04-01 21:08:10.969+0900 D/AUL     (10522): app_sock.c: __create_server_sock(136) > pg path - already exists
04-01 21:08:10.969+0900 D/LAUNCH  (10522): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
04-01 21:08:10.979+0900 D/EFL-ASSIST(10522): efl_assist_theme.c: ea_theme_changeable_ui_enabled_set(267) > changeable state is set to 1
04-01 21:08:10.979+0900 D/EFL-ASSIST(10522): efl_assist_theme.c: _theme_color_monitor_add(239) > color config file (/opt/home/app/.elementary/config/wearable/color.cfg) monitor is added!!
04-01 21:08:10.979+0900 I/EFL-ASSIST(10522): efl_assist_theme.c: _theme_changeable_ui_data_set(220) > changeable state [1] is set to ecore_evas [b7e8a7b8]
04-01 21:08:10.979+0900 D/EFL-ASSIST(10522): efl_assist_theme_color.c: ea_theme_style_set(951) > changeable state: 1,  winset style (0)
04-01 21:08:10.979+0900 I/EFL-ASSIST(10522): efl_assist_theme_color.c: _color_config_get(215) > read color config file from (/opt/home/app/.elementary/config/wearable/color.cfg)
04-01 21:08:10.979+0900 I/EFL-ASSIST(10522): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (b7ea9758) from (/usr/share/themes/ChangeableColorTable1.xml) is created
04-01 21:08:10.979+0900 I/EFL-ASSIST(10522): efl_assist_theme_color.c: ea_theme_color_table_free(766) > color table (b7ea9758) is freed
04-01 21:08:10.979+0900 I/EFL-ASSIST(10522): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (0) from (system-color.xml) is created
04-01 21:08:10.979+0900 I/EFL-ASSIST(10522): efl_assist_theme_font.c: ea_theme_font_table_new(381) > font table (0) from (system-font.xml) is created
04-01 21:08:10.979+0900 D/APP_CORE(10522): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
04-01 21:08:10.979+0900 D/LAUNCH  (10522): appcore-efl.c: __before_loop(1047) > [crash-popup:Application:create:done]
04-01 21:08:10.979+0900 D/APP_CORE(10522): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
04-01 21:08:10.979+0900 D/APP_CORE(10522): appcore.c: __aul_handler(423) > [APP 10522]     AUL event: AUL_START
04-01 21:08:10.979+0900 D/APP_CORE(10522): appcore-efl.c: __do_app(470) > [APP 10522] Event: RESET State: CREATED
04-01 21:08:10.979+0900 D/APP_CORE(10522): appcore-efl.c: __do_app(496) > [APP 10522] RESET
04-01 21:08:10.979+0900 D/LAUNCH  (10522): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
04-01 21:08:10.979+0900 D/CRASH_POPUP(10522): crash.c: app_reset(226) > bundle_get_val - process_name:flyingbird
04-01 21:08:10.979+0900 D/CRASH_POPUP(10522): crash.c: app_reset(234) > bundle_get_val - exepath:/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
04-01 21:08:10.979+0900 D/PKGMGR_INFO(10522): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.979+0900 D/PKGMGR_INFO(10522): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.979+0900 D/PKGMGR_INFO(10522): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.979+0900 D/PKGMGR_INFO(10522): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird' and package_app_info.app_disable IN ('false','False')
04-01 21:08:10.979+0900 I/CRASH_POPUP(10522): crash.c: load_crash_process_popup(117) > Popup content: Flying Bird has closed unexpectedly.
04-01 21:08:10.999+0900 E/EFL     (10522): eina_module<10522> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
04-01 21:08:11.059+0900 D/AUL_PAD ( 2108): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
04-01 21:08:11.059+0900 D/AUL_PAD ( 2108): sigchild.h: __send_app_launch_signal(112) > send launch signal done
04-01 21:08:11.059+0900 D/AUL_PAD ( 2108): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
04-01 21:08:11.059+0900 D/AUL     ( 2105): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
04-01 21:08:11.059+0900 E/AUL     ( 2105): simple_util.c: __trm_app_info_send_socket(264) > access
04-01 21:08:11.059+0900 D/RESOURCED( 2356): proc-noti.c: recv_str(87) > [recv_str,87] str is null
04-01 21:08:11.059+0900 D/RESOURCED( 2356): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2105
04-01 21:08:11.059+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 10522, type 4 
04-01 21:08:11.059+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 10522
04-01 21:08:11.059+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
04-01 21:08:11.059+0900 E/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 354
04-01 21:08:11.059+0900 D/RESOURCED( 2356): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
04-01 21:08:11.059+0900 D/AUL     (10521): launch.c: app_request_to_launchpad(295) > launch request result : 10522
04-01 21:08:11.059+0900 E/AUL_AMD ( 2105): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
04-01 21:08:11.059+0900 D/STARTER ( 2226): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
04-01 21:08:11.059+0900 W/STARTER ( 2226): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: on_changed_receive(1246) > org.tizen.system.deviced.display - LCDOn
04-01 21:08:11.059+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
04-01 21:08:11.059+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
04-01 21:08:11.059+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: preference_get_int(1063) > preference_get_int(2238) : key(clock_font_color) error
04-01 21:08:11.059+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
04-01 21:08:11.059+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
04-01 21:08:11.059+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: preference_get_int(1063) > preference_get_int(2238) : key(showdate) error
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(849) > show_date:1
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(9)[Fri 1 Apr][1459512491]
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(857) > 
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1459512491]
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[9:08][1459512491]
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(871) > utc_time=9:08, utc_ampm=[2]PM
04-01 21:08:11.059+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>9:08<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
04-01 21:08:11.059+0900 D/LAUNCH  (10522): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
04-01 21:08:11.059+0900 I/APP_CORE(10522): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
04-01 21:08:11.059+0900 I/APP_CORE(10522): appcore-efl.c: __do_app(509) > [APP 10522] Initial Launching, call the resume_cb
04-01 21:08:11.059+0900 D/APP_CORE(10522): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
04-01 21:08:11.059+0900 D/APP_CORE(10522): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00006
04-01 21:08:11.059+0900 D/APP_CORE(10522): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1e00006
04-01 21:08:11.069+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [0]
04-01 21:08:11.069+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
04-01 21:08:11.069+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
04-01 21:08:11.069+0900 D/DATA_PROVIDER_MASTER( 2260): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
04-01 21:08:11.069+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
04-01 21:08:11.069+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
04-01 21:08:11.129+0900 W/W_HOME  ( 2236): dbus.c: _dbus_message_recv_cb(178) > LCD on
04-01 21:08:11.129+0900 W/W_HOME  ( 2236): main.c: _lcd_on_cb(951) > LCD: off->on
04-01 21:08:11.129+0900 D/W_HOME  ( 2236): clock_event.c: _display_state_cb(194) > LCD: off->on
04-01 21:08:11.129+0900 D/W_HOME  ( 2236): clock_view.c: clock_view_event_handler(843) > event:40000 received
04-01 21:08:11.129+0900 D/W_HOME  ( 2236): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
04-01 21:08:11.159+0900 D/APP_CORE(10522): appcore.c: __prt_ltime(183) > [APP 10522] first idle after reset: 215 msec
04-01 21:08:11.179+0900 D/APP_CORE(10522): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1e00006 fully_obscured 0
04-01 21:08:11.179+0900 D/AUL_AMD ( 2105): amd_launch.c: __e17_status_handler(1911) > pid(10522) status(3)
04-01 21:08:11.179+0900 D/RESOURCED( 2356): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 10522, type = 0
04-01 21:08:11.179+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 10522
04-01 21:08:11.179+0900 I/RESOURCED( 2356): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 10522, oom : 200
04-01 21:08:11.179+0900 E/RESOURCED( 2356): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
04-01 21:08:11.179+0900 E/RESOURCED( 2356): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (10522) didn't have any process list
04-01 21:08:11.179+0900 D/RESOURCED( 2356): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 10522, appname = (null)
04-01 21:08:11.179+0900 D/RESOURCED( 2356): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10522
04-01 21:08:11.179+0900 D/APP_CORE(10522): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
04-01 21:08:11.179+0900 D/APP_CORE(10522): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
04-01 21:08:11.179+0900 D/APP_CORE(10522): appcore-efl.c: __do_app(470) > [APP 10522] Event: RESUME State: RUNNING
04-01 21:08:11.179+0900 D/LAUNCH  (10522): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
04-01 21:08:11.179+0900 D/LAUNCH  (10522): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
04-01 21:08:11.179+0900 D/LAUNCH  (10522): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
04-01 21:08:11.179+0900 D/APP_CORE(10522): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
04-01 21:08:11.179+0900 E/APP_CORE(10522): appcore-efl.c: __trm_app_info_send_socket(233) > access
04-01 21:08:11.289+0900 D/AUL_AMD ( 2105): amd_launch.c: __e17_status_handler(1911) > pid(2236) status(3)
04-01 21:08:11.289+0900 D/RESOURCED( 2356): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2236, type = 0
04-01 21:08:11.289+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2236
04-01 21:08:11.289+0900 E/RESOURCED( 2356): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (2236) didn't have any process list
04-01 21:08:11.289+0900 D/RESOURCED( 2356): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2236, appname = (null)
04-01 21:08:11.289+0900 D/RESOURCED( 2356): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2236
04-01 21:08:11.419+0900 W/W_HOME  ( 2236): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(0)
04-01 21:08:11.419+0900 D/APP_CORE( 2236): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 0
04-01 21:08:11.419+0900 D/APP_CORE( 2236): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
04-01 21:08:11.419+0900 D/APP_CORE( 2236): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
04-01 21:08:11.419+0900 D/APP_CORE( 2236): appcore-efl.c: __do_app(470) > [APP 2236] Event: RESUME State: PAUSED
04-01 21:08:11.419+0900 D/LAUNCH  ( 2236): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
04-01 21:08:11.419+0900 D/APP_CORE( 2236): appcore-efl.c: __do_app(559) > [APP 2236] RESUME
04-01 21:08:11.419+0900 I/CAPI_APPFW_APPLICATION( 2236): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
04-01 21:08:11.419+0900 D/W_HOME  ( 2236): main.c: _resume_cb(564) > Resumed
04-01 21:08:11.419+0900 D/APPS    ( 2236): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
04-01 21:08:11.419+0900 D/W_HOME  ( 2236): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
04-01 21:08:11.419+0900 E/efl-extension( 2236): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb7fbc5d0, elm_scroller, _activated_obj : 0xb7fbc5d0, activated : 1
04-01 21:08:11.419+0900 W/W_HOME  ( 2236): main.c: _resume_cb(589) > clock/widget resumed
04-01 21:08:11.419+0900 D/W_HOME  ( 2236): clock_view.c: clock_view_event_handler(843) > event:10004 received
04-01 21:08:11.419+0900 D/W_HOME  ( 2236): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
04-01 21:08:11.419+0900 D/W_HOME  ( 2236): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb8066e20 is resumed
04-01 21:08:11.419+0900 D/LAUNCH  ( 2236): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
04-01 21:08:11.419+0900 D/LAUNCH  ( 2236): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
04-01 21:08:11.419+0900 D/APP_CORE( 2236): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
04-01 21:08:11.419+0900 E/APP_CORE( 2236): appcore-efl.c: __trm_app_info_send_socket(233) > access
04-01 21:08:11.419+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=10
04-01 21:08:11.419+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_resume
04-01 21:08:11.419+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _ecore_evas_msg_parent_handle(1291) > ##### mc_resume
04-01 21:08:11.429+0900 D/DATA_PROVIDER_MASTER( 2260): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2236 is resumed
04-01 21:08:11.429+0900 D/DATA_PROVIDER_MASTER( 2260): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
04-01 21:08:12.059+0900 D/AUL_AMD ( 2105): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
04-01 21:08:12.059+0900 D/RUA     ( 2105): rua.c: rua_add_history(179) > rua_add_history start
04-01 21:08:12.059+0900 D/RUA     ( 2105): rua.c: rua_add_history(247) > rua_add_history ok
04-01 21:08:18.019+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [1]
04-01 21:08:18.019+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _device_state_changed_cb(1108) > Not interested PM STATE
04-01 21:08:18.019+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 2[0;m
04-01 21:08:18.019+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
04-01 21:08:18.019+0900 D/DATA_PROVIDER_MASTER( 2260): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
04-01 21:08:19.169+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: main(1436) > server start
04-01 21:08:19.169+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: main(1505) > Main loop is created.
04-01 21:08:19.169+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(144) > called
04-01 21:08:19.169+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(155) > done
04-01 21:08:19.169+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkg_mgr_object_init(93) > called
04-01 21:08:19.169+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > RequestName returns: 1
04-01 21:08:19.169+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkg_mgr_object_init(135) > Ready to serve requests
04-01 21:08:19.179+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkg_mgr_object_init(139) > done
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: main(1510) > pkg_mgr object is created, and request callback is registered.
04-01 21:08:19.179+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkgmgr_request(194) > Called
04-01 21:08:19.179+0900 D/PKGMGR  (10588): comm_pkg_mgr_server.c: pkgmgr_request(203) > [SECURE_LOG] Call request callback(obj, org.exelim.flyingbird_1007598295, 11, rpm, org.exelim.flyingbird, , *ret)
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: req_cb(431) > [SECURE_LOG] >> in callback >> Got request: [org.exelim.flyingbird_1007598295] [11] [rpm] [org.exelim.flyingbird] [] []
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: __register_signal_handler(382) > signal: SIGCHLD succeed
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: __register_signal_handler(384) > g_timeout_add_seconds() Added to Main Loop
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: req_cb(450) > req_type=(11)  backend_flag=(0)
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: queue_job(1168) > saved queue status. Now try fork()
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: queue_job(1175) > child forked [10589] for request type [11]
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: queue_job(1347) > parent exit
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10589): pkgmgr-server.c: queue_job(1175) > child forked [0] for request type [11]
04-01 21:08:19.179+0900 D/PKGMGR_SERVER(10589): pkgmgr-server.c: __make_pid_info_file(825) > File path = /tmp/org.exelim.flyingbird
04-01 21:08:19.199+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: sighandler(326) > child exit [10589]
04-01 21:08:19.199+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: sighandler(341) > child NORMAL exit [10589]
04-01 21:08:20.999+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: exit_server(724) > exit_server Start
04-01 21:08:20.999+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: main(1516) > Quit main loop.
04-01 21:08:20.999+0900 D/PKGMGR_SERVER(10588): pkgmgr-server.c: main(1524) > package manager server terminated.
04-01 21:08:21.019+0900 W/STARTER ( 2226): clock-mgr.c: _notify_pm_lcdoff_cb(463) > [_notify_pm_lcdoff_cb:463] LCD OFF by lcd off source[2], wake_up_setting[1], ALPM_clock_state[0]
04-01 21:08:21.019+0900 E/STARTER ( 2226): clock-mgr.c: _notify_pm_lcdoff_cb(482) > [_notify_pm_lcdoff_cb:482] Failed to get [memory/setup_wizard/state]
04-01 21:08:21.019+0900 W/STARTER ( 2226): clock-mgr.c: _check_reserved_popup_status(93) > [_check_reserved_popup_status:93] Current reserved apps status : 0
04-01 21:08:21.019+0900 W/STARTER ( 2226): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
04-01 21:08:21.019+0900 E/STARTER ( 2226): clock-mgr.c: _notify_pm_lcdoff_cb(666) > [_notify_pm_lcdoff_cb:666] Failed to get VCONFKEY_SETTING_SIMPLE_CLOCK_MODE
04-01 21:08:21.019+0900 W/STARTER ( 2226): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
04-01 21:08:21.019+0900 W/STARTER ( 2226): clock-mgr.c: _notify_pm_lcdoff_cb(674) > [_notify_pm_lcdoff_cb:674] Not reserved apss status AND wake_up_setting is CLOCK => show simple clock..!!
04-01 21:08:21.019+0900 E/STARTER ( 2226): dbus-util_w.c: _dbus_message_send(149) > [_dbus_message_send:149] dbus_message_new_signal(/Org/Tizen/Coreapps/starter:org.tizen.coreapps.starter.alpmclock-show)
04-01 21:08:21.019+0900 D/STARTER ( 2226): dbus-util_w.c: _dbus_message_send(163) > [_dbus_message_send:163] dbus_connection_send, ret=1
04-01 21:08:21.019+0900 E/STARTER ( 2226): dbus-util_w.c: starter_dbus_alpm_clock_signal_send(187) > [starter_dbus_alpm_clock_signal_send:187] Sending alpmclock show signal, result:0
04-01 21:08:21.019+0900 E/AUL_AMD ( 2105): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
04-01 21:08:21.019+0900 W/W_HOME  ( 2236): dbus.c: _dbus_message_recv_cb(190) > LCD on
04-01 21:08:21.019+0900 E/W_HOME  ( 2236): dbus.c: _dbus_message_recv_cb(197) > Failed to get reply (org.freedesktop.DBus.Error.InvalidArgs:Argument 0 is specified to be of type "string", but is actually of type "invalid"
04-01 21:08:21.019+0900 E/W_HOME  ( 2236): )
04-01 21:08:21.019+0900 D/W_HOME  ( 2236): main.c: _lcd_off_cb(967) > LCD: on->off
04-01 21:08:21.019+0900 W/W_HOME  ( 2236): main.c: _lcd_off_cb(970) > clock/widget paused
04-01 21:08:21.019+0900 D/W_HOME  ( 2236): clock_view.c: clock_view_event_handler(843) > event:10002 received
04-01 21:08:21.019+0900 D/W_HOME  ( 2236): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb8066e20 is paused
04-01 21:08:21.019+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
04-01 21:08:21.019+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
04-01 21:08:21.019+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
04-01 21:08:21.019+0900 D/STARTER ( 2226): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
04-01 21:08:21.019+0900 W/STARTER ( 2226): dbus-util_w.c: _on_lcd_changed_receive(632) > [_on_lcd_changed_receive:632] LCD off
04-01 21:08:21.029+0900 D/DATA_PROVIDER_MASTER( 2260): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2236 is paused
04-01 21:08:21.029+0900 D/DATA_PROVIDER_MASTER( 2260): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
04-01 21:08:21.119+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [2]
04-01 21:08:21.119+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 3[0;m
04-01 21:08:21.119+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
04-01 21:08:21.119+0900 D/DATA_PROVIDER_MASTER( 2260): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
04-01 21:08:21.119+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:3,lock_state:0[0;m
04-01 21:08:21.119+0900 D/W_HOME  ( 2236): clock_event.c: _display_state_cb(197) > LCD: on->off
04-01 21:08:21.119+0900 D/W_HOME  ( 2236): clock_view.c: clock_view_event_handler(843) > event:40001 received
04-01 21:08:21.119+0900 D/W_HOME  ( 2236): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:0, is_need_vi:0
04-01 21:08:21.619+0900 D/NET_NFC_MANAGER( 2264): net_nfc_server_common.c: restart_polling_loop_thread_func(484) > [0;35mpolling disabled[0;m
04-01 21:08:22.389+0900 D/AUL_AMD ( 2105): amd_request.c: __request_handler(495) > __request_handler: 0
04-01 21:08:22.389+0900 D/AUL_AMD ( 2105): amd_request.c: __request_handler(540) > launch a single-instance appid: org.exelim.flyingbird
04-01 21:08:22.389+0900 D/AUL     ( 2105): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 10643, pid = 10645
04-01 21:08:22.389+0900 D/AUL_AMD ( 2105): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
04-01 21:08:22.389+0900 D/AUL_AMD ( 2105): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 21:08:22.389+0900 D/AUL     ( 2105): app_sock.c: __app_send_raw(265) > pid(-4) : cmd(0)
04-01 21:08:22.489+0900 E/AUL_PAD ( 2136): launchpad.c: __launchpad_main_loop(1177) > faild to get app pid
04-01 21:08:22.489+0900 D/AUL     ( 2105): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
04-01 21:08:22.489+0900 E/AUL     ( 2105): simple_util.c: __trm_app_info_send_socket(264) > access
04-01 21:08:22.489+0900 D/RESOURCED( 2356): proc-noti.c: recv_str(87) > [recv_str,87] str is null
04-01 21:08:22.489+0900 D/RESOURCED( 2356): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2105
04-01 21:08:22.489+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.exelim.flyingbird, pid 10646, type 4 
04-01 21:08:22.489+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.exelim.flyingbird, 10646
04-01 21:08:22.489+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.exelim.flyingbird with pkgname
04-01 21:08:22.489+0900 E/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 358
04-01 21:08:22.489+0900 D/RESOURCED( 2356): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
04-01 21:08:23.489+0900 D/AUL_AMD ( 2105): amd_launch.c: __grab_timeout_handler(1212) > pid(10646) ecore_x_pointer_ungrab
04-01 21:08:23.489+0900 D/AUL_AMD ( 2105): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.exelim.flyingbird /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
04-01 21:08:23.489+0900 D/RUA     ( 2105): rua.c: rua_add_history(179) > rua_add_history start
04-01 21:08:23.499+0900 D/RUA     ( 2105): rua.c: rua_add_history(247) > rua_add_history ok
04-01 21:08:23.649+0900 I/efl-extension(10648): efl_extension.c: eext_mod_init(39) > Init
04-01 21:08:23.649+0900 D/AUL     (10648): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 10648 is org.exelim.flyingbird
04-01 21:08:23.649+0900 I/CAPI_APPFW_APPLICATION(10648): app_main.c: ui_app_main(701) > app_efl_main
04-01 21:08:23.649+0900 D/LAUNCH  (10648): appcore-efl.c: appcore_efl_main(1571) > [flyingbird:Application:main:done]
04-01 21:08:23.649+0900 D/AUL     (10648): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 10648 is org.exelim.flyingbird
04-01 21:08:23.789+0900 D/APP_CORE(10648): appcore-efl.c: __before_loop(1012) > elm_config_preferred_engine_set : opengl_x11
04-01 21:08:23.789+0900 D/AUL     (10648): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 10648 is org.exelim.flyingbird
04-01 21:08:23.789+0900 D/APP_CORE(10648): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.exelim.flyingbird/res/locale
04-01 21:08:23.789+0900 D/APP_CORE(10648): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
04-01 21:08:23.789+0900 D/AUL     (10648): app_sock.c: __create_server_sock(136) > pg path - already exists
04-01 21:08:23.789+0900 D/LAUNCH  (10648): appcore-efl.c: __before_loop(1035) > [flyingbird:Platform:appcore_init:done]
04-01 21:08:23.789+0900 I/CAPI_APPFW_APPLICATION(10648): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
04-01 21:08:24.279+0900 D/LAUNCH  (10648): appcore-efl.c: __before_loop(1047) > [flyingbird:Application:create:done]
04-01 21:08:24.279+0900 D/APP_CORE(10648): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
04-01 21:08:24.279+0900 D/APP_CORE(10648): appcore.c: __aul_handler(423) > [APP 10648]     AUL event: AUL_START
04-01 21:08:24.279+0900 D/APP_CORE(10648): appcore-efl.c: __do_app(470) > [APP 10648] Event: RESET State: CREATED
04-01 21:08:24.279+0900 D/APP_CORE(10648): appcore-efl.c: __do_app(496) > [APP 10648] RESET
04-01 21:08:24.279+0900 D/LAUNCH  (10648): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
04-01 21:08:24.279+0900 I/CAPI_APPFW_APPLICATION(10648): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
04-01 21:08:24.279+0900 D/APP_SVC (10648): appsvc.c: __set_bundle(161) > __set_bundle
04-01 21:08:24.279+0900 D/LAUNCH  (10648): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
04-01 21:08:24.279+0900 E/PKGMGR_INFO(10648): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1327) > (appid == NULL) appid is NULL
04-01 21:08:24.279+0900 I/APP_CORE(10648): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
04-01 21:08:24.279+0900 I/APP_CORE(10648): appcore-efl.c: __do_app(509) > [APP 10648] Initial Launching, call the resume_cb
04-01 21:08:24.279+0900 I/CAPI_APPFW_APPLICATION(10648): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
04-01 21:08:24.279+0900 D/APP_CORE(10648): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
04-01 21:08:24.279+0900 D/APP_CORE(10648): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00003
04-01 21:08:24.279+0900 D/APP_CORE(10648): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00003
04-01 21:08:31.879+0900 D/AUL     (10648): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 10648 is org.exelim.flyingbird
04-01 21:08:34.259+0900 W/W_HOME  ( 2236): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
04-01 21:08:34.259+0900 D/APP_CORE( 2236): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
04-01 21:08:34.259+0900 D/APP_CORE( 2236): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
04-01 21:08:34.259+0900 D/APP_CORE( 2236): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
04-01 21:08:34.259+0900 D/APP_CORE( 2236): appcore-efl.c: __do_app(470) > [APP 2236] Event: PAUSE State: RUNNING
04-01 21:08:34.259+0900 D/APP_CORE( 2236): appcore-efl.c: __do_app(538) > [APP 2236] PAUSE
04-01 21:08:34.259+0900 I/CAPI_APPFW_APPLICATION( 2236): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
04-01 21:08:34.259+0900 D/W_HOME  ( 2236): main.c: _pause_cb(600) > Paused
04-01 21:08:34.259+0900 D/W_HOME  ( 2236): page.c: page_focus(701) > focus set to 0xb8105930
04-01 21:08:34.259+0900 W/W_HOME  ( 2236): main.c: _pause_cb(613) > clock/widget paused
04-01 21:08:34.259+0900 D/W_HOME  ( 2236): clock_view.c: clock_view_event_handler(843) > event:10002 received
04-01 21:08:34.259+0900 D/APP_CORE( 2236): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
04-01 21:08:34.259+0900 E/APP_CORE( 2236): appcore-efl.c: __trm_app_info_send_socket(233) > access
04-01 21:08:34.269+0900 D/RESOURCED( 2356): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2236, type = 2
04-01 21:08:34.269+0900 D/AUL_AMD ( 2105): amd_launch.c: __e17_status_handler(1911) > pid(10648) status(3)
04-01 21:08:34.269+0900 D/RESOURCED( 2356): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 10648, type = 0
04-01 21:08:34.269+0900 D/RESOURCED( 2356): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 10648
04-01 21:08:34.269+0900 E/RESOURCED( 2356): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (10648) didn't have any process list
04-01 21:08:34.269+0900 D/RESOURCED( 2356): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 10648, appname = (null)
04-01 21:08:34.269+0900 D/RESOURCED( 2356): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10648
04-01 21:08:34.329+0900 D/DATA_PROVIDER_MASTER( 2260): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2236 is paused
04-01 21:08:34.329+0900 D/DATA_PROVIDER_MASTER( 2260): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
04-01 21:08:36.299+0900 E/RESOURCED( 2356): proc-monitor.c: edbus_signal_trigger(467) > [edbus_signal_trigger,467] Receive watchdog signal to pid: 10648(flyingbird)
04-01 21:08:39.339+0900 D/APP_CORE( 2236): appcore-efl.c: __do_app(470) > [APP 2236] Event: MEM_FLUSH State: PAUSED
04-01 21:09:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
04-01 21:09:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
04-01 21:09:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: preference_get_int(1063) > preference_get_int(2238) : key(clock_font_color) error
04-01 21:09:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
04-01 21:09:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
04-01 21:09:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2238): preference.c: preference_get_int(1063) > preference_get_int(2238) : key(showdate) error
04-01 21:09:00.109+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(849) > show_date:1
04-01 21:09:00.109+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(9)[Fri 1 Apr][1459512540]
04-01 21:09:00.109+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(857) > 
04-01 21:09:00.109+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1459512540]
04-01 21:09:00.109+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[9:09][1459512540]
04-01 21:09:00.109+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(871) > utc_time=9:09, utc_ampm=[2]PM
04-01 21:09:00.109+0900 D/IDLE-CLOCK-DIGITAL( 2238): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>9:09<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
04-01 21:09:08.388+0900 W/CRASH_MANAGER(10653): worker.c: worker_job(1189) > 1110648666c79145951254
