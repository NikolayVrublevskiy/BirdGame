S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20150902.2338
Build-Date: 2015.09.02 23:38:00

Crash Information
Process Name: flyingbird
PID: 24263
Date: 2016-03-17 20:28:13+0900
Executable File Path: /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb44fa000

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00400000, esi = 0x80085d70
ebp = 0xbfffef98, esp = 0xbfffef50
eax = 0x00204ff8, ebx = 0xb46d74a4
ecx = 0xb42f5008, edx = 0x00000077
eip = 0xb46c3be0

Memory Information
MemTotal:      124 KB
MemFree:        51 KB
Buffers:        11 KB
Cached:     149888 KB
VmPeak:      65740 KB
VmSize:      65740 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15284 KB
VmRSS:       15284 KB
VmData:       5656 KB
VmStk:         136 KB
VmExe:          76 KB
VmLib:       32032 KB
VmPTE:          56 KB
VmSwap:          0 KB

Maps Information
80000000 80013000 r-xp /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
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

Callstack Information (PID:24263)
Call Stack Count: 22
 0: yagl_transport_end + 0x290 (0xb46c3be0) [/usr/lib/libEGL.so.1] + 0x5be0
 1: (0xb4703dec) [/usr/lib/libGLESv2.so.2] + 0x2bdec
 2: glTexImage2D + 0x25e (0xb46fff7e) [/usr/lib/libGLESv2.so.2] + 0x27f7e
 3: Font::LoadFont(char const*) + 0x332 (0x800049fa) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x49fa
 4: Font::Init(char const*, char const*, char const*) + 0x7f (0x8000408d) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0x408d
 5: init_gl(_Evas_Object*) + 0x42 (0x8000c776) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xc776
 6: (0xb7e45307) [/usr/lib/libelementary.so.1] + 0xd6307
 7: (0xb472e42d) [/usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so] + 0xb42d
 8: (0xb7c581c1) [/usr/lib/libevas.so.1] + 0x2e1c1
 9: (0xb7ca5635) [/usr/lib/libevas.so.1] + 0x7b635
10: (0xb7ca9305) [/usr/lib/libevas.so.1] + 0x7f305
11: (0xb73958d7) [/usr/lib/libecore_evas.so.1] + 0x158d7
12: ecore_evas_manual_render + 0x5d (0xb73905cd) [/usr/lib/libecore_evas.so.1] + 0x105cd
13: (0xb7394879) [/usr/lib/libecore_evas.so.1] + 0x14879
14: (0xb7fa7852) [/usr/lib/libecore.so.1] + 0xc852
15: (0xb7fa92fd) [/usr/lib/libecore.so.1] + 0xe2fd
16: ecore_main_loop_begin + 0x3f (0xb7fa99cf) [/usr/lib/libecore.so.1] + 0xe9cf
17: elm_run + 0x17 (0xb7e76867) [/usr/lib/libelementary.so.1] + 0x107867
18: appcore_efl_main + 0x3d1 (0xb793ee91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
19: ui_app_main + 0x130 (0xb7fd0500) [/usr/lib/libcapi-appfw-application.so.0] + 0x2500
20: main + 0xb9 (0x8000d71f) [/opt/usr/apps/org.exelim.flyingbird/bin/flyingbird] + 0xd71f
21: __libc_start_main + 0xf3 (0xb79be0f3) [/lib/libc.so.6] + 0x190f3
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
__do_app(498) > [flyingbird:Application:reset:start]
03-17 20:14:35.192+0900 I/CAPI_APPFW_APPLICATION(24060): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-17 20:14:35.192+0900 D/APP_SVC (24060): appsvc.c: __set_bundle(161) > __set_bundle
03-17 20:14:35.192+0900 D/LAUNCH  (24060): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
03-17 20:14:35.192+0900 E/PKGMGR_INFO(24060): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1327) > (appid == NULL) appid is NULL
03-17 20:14:35.192+0900 I/APP_CORE(24060): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-17 20:14:35.192+0900 I/APP_CORE(24060): appcore-efl.c: __do_app(509) > [APP 24060] Initial Launching, call the resume_cb
03-17 20:14:35.192+0900 I/CAPI_APPFW_APPLICATION(24060): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-17 20:14:35.192+0900 D/APP_CORE(24060): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-17 20:14:35.192+0900 D/APP_CORE(24060): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00003
03-17 20:14:35.192+0900 D/APP_CORE(24060): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00003
03-17 20:14:35.192+0900 D/AUL     (24060): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 24060 is org.exelim.flyingbird
03-17 20:14:38.742+0900 D/STARTER ( 2215): hw_key_w.c: _key_press_cb(1107) > [_key_press_cb:1107] _key_press_cb : XF86PowerOff Pressed
03-17 20:14:38.742+0900 W/STARTER ( 2215): hw_key_w.c: _key_press_cb(1112) > [_key_press_cb:1112] POWER Key is pressed
03-17 20:14:38.742+0900 W/STARTER ( 2215): hw_key_w.c: _key_press_cb(1118) > [_key_press_cb:1118] LCD state : 3
03-17 20:14:38.742+0900 E/STARTER ( 2215): hw_key_w.c: _key_press_cb(1127) > [_key_press_cb:1127] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
03-17 20:14:38.742+0900 W/STARTER ( 2215): hw_key_w.c: _key_press_cb(1130) > [_key_press_cb:1130] Simple Clock state : 0
03-17 20:14:38.742+0900 W/STARTER ( 2215): hw_key_w.c: _key_press_cb(1135) > [_key_press_cb:1135] powerkey count : 1
03-17 20:14:38.742+0900 D/STARTER ( 2215): hw_key_w.c: _key_press_cb(1149) > [_key_press_cb:1149] create long press timer
03-17 20:14:38.752+0900 W/W_HOME  ( 2221): dbus.c: _dbus_message_recv_cb(178) > LCD on
03-17 20:14:38.752+0900 W/W_HOME  ( 2221): main.c: _lcd_on_cb(951) > LCD: off->on
03-17 20:14:38.752+0900 D/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
03-17 20:14:38.752+0900 W/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
03-17 20:14:38.752+0900 E/AUL_AMD ( 2100): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: on_changed_receive(1246) > org.tizen.system.deviced.display - LCDOn
03-17 20:14:38.752+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-17 20:14:38.752+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-17 20:14:38.752+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(clock_font_color) error
03-17 20:14:38.752+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-17 20:14:38.752+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-17 20:14:38.752+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(showdate) error
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Thu 17 Mar][1458213278]
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(857) > 
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1458213278]
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[8:14][1458213278]
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(871) > utc_time=8:14, utc_ampm=[2]PM
03-17 20:14:38.752+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>8:14<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
03-17 20:14:38.762+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-17 20:14:38.762+0900 D/W_HOME  ( 2221): clock_event.c: _display_state_cb(194) > LCD: off->on
03-17 20:14:38.762+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:40000 received
03-17 20:14:38.762+0900 D/W_HOME  ( 2221): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-17 20:14:38.762+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
03-17 20:14:38.762+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-17 20:14:38.762+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
03-17 20:14:38.762+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
03-17 20:14:38.762+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [0]
03-17 20:14:38.922+0900 D/STARTER ( 2215): hw_key_w.c: _key_release_cb(1038) > [_key_release_cb:1038] _key_release_cb : XF86PowerOff Released
03-17 20:14:38.922+0900 W/STARTER ( 2215): hw_key_w.c: _key_release_cb(1043) > [_key_release_cb:1043] POWER Key is released
03-17 20:14:38.922+0900 D/STARTER ( 2215): hw_key_w.c: _key_release_cb(1049) > [_key_release_cb:1049] delete long press timer
03-17 20:14:38.922+0900 D/STARTER ( 2215): hw_key_w.c: _key_release_cb(1075) > [_key_release_cb:1075] lcd off --> [0.400000]sec timer
03-17 20:14:39.322+0900 W/STARTER ( 2215): hw_key_w.c: _powerkey_timer_cb(777) > [_powerkey_timer_cb:777] _powerkey_timer_cb, powerkey count[1]
03-17 20:14:39.322+0900 E/STARTER ( 2215): hw_key_w.c: _powerkey_timer_cb(796) > [SECURE_LOG] [_powerkey_timer_cb:796] Failed to get vconfkey[memory/setup_wizard/state]
03-17 20:14:39.322+0900 E/STARTER ( 2215): hw_key_w.c: _powerkey_timer_cb(825) > [SECURE_LOG] [_powerkey_timer_cb:825] Failed to get vconfkey[db/wms/safety_enable]
03-17 20:14:39.322+0900 W/STARTER ( 2215): hw_key_w.c: _powerkey_timer_cb(891) > [_powerkey_timer_cb:891] just turn on LCD by powerkey.. starter ignore powerkey operation
03-17 20:14:45.232+0900 W/W_HOME  ( 2221): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
03-17 20:14:45.232+0900 D/APP_CORE( 2221): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
03-17 20:14:45.232+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-17 20:14:45.232+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-17 20:14:45.232+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(470) > [APP 2221] Event: PAUSE State: RUNNING
03-17 20:14:45.232+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(538) > [APP 2221] PAUSE
03-17 20:14:45.232+0900 I/CAPI_APPFW_APPLICATION( 2221): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-17 20:14:45.232+0900 D/W_HOME  ( 2221): main.c: _pause_cb(600) > Paused
03-17 20:14:45.232+0900 E/W_HOME  ( 2221): main.c: _pause_cb(603) > paused already
03-17 20:14:45.232+0900 D/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-17 20:14:45.232+0900 E/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-17 20:14:45.232+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2221, type = 2
03-17 20:14:45.242+0900 D/AUL_AMD ( 2100): amd_launch.c: __e17_status_handler(1911) > pid(24060) status(3)
03-17 20:14:45.242+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 24060, type = 0
03-17 20:14:45.242+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 24060
03-17 20:14:45.242+0900 E/RESOURCED( 2344): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (24060) didn't have any process list
03-17 20:14:45.242+0900 D/RESOURCED( 2344): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 24060, appname = (null)
03-17 20:14:45.242+0900 D/RESOURCED( 2344): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 24060
03-17 20:14:45.742+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [1]
03-17 20:14:45.742+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1108) > Not interested PM STATE
03-17 20:14:45.742+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-17 20:14:45.742+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 2[0;m
03-17 20:14:45.742+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-17 20:14:45.952+0900 E/RESOURCED( 2344): proc-monitor.c: edbus_signal_trigger(467) > [edbus_signal_trigger,467] Receive watchdog signal to pid: 24060(flyingbird)
03-17 20:14:46.422+0900 D/AUL_AMD ( 2100): amd_launch.c: __e17_status_handler(1911) > pid(2221) status(3)
03-17 20:14:46.422+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2221, type = 0
03-17 20:14:46.422+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2221
03-17 20:14:46.422+0900 D/RESOURCED( 2344): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2221, appname = (null)
03-17 20:14:46.422+0900 D/RESOURCED( 2344): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2221
03-17 20:14:46.522+0900 D/W_HOME  ( 2221): main.c: _window_focus_in_cb(848) > focus in
03-17 20:14:46.522+0900 D/W_HOME  ( 2221): main.c: _resume_cb(564) > Resumed
03-17 20:14:46.522+0900 D/APPS    ( 2221): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
03-17 20:14:46.522+0900 D/W_HOME  ( 2221): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
03-17 20:14:46.522+0900 E/efl-extension( 2221): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb931f320, elm_scroller, _activated_obj : 0xb931f320, activated : 1
03-17 20:14:46.522+0900 W/W_HOME  ( 2221): main.c: _resume_cb(589) > clock/widget resumed
03-17 20:14:46.522+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10004 received
03-17 20:14:46.522+0900 D/W_HOME  ( 2221): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-17 20:14:46.522+0900 D/W_HOME  ( 2221): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb939c8a0 is resumed
03-17 20:14:46.522+0900 E/APPS    ( 2221): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
03-17 20:14:46.522+0900 W/W_HOME  ( 2221): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(0)
03-17 20:14:46.522+0900 D/APP_CORE( 2221): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 0
03-17 20:14:46.522+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
03-17 20:14:46.522+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-17 20:14:46.522+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(470) > [APP 2221] Event: RESUME State: PAUSED
03-17 20:14:46.522+0900 D/LAUNCH  ( 2221): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
03-17 20:14:46.522+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(559) > [APP 2221] RESUME
03-17 20:14:46.522+0900 I/CAPI_APPFW_APPLICATION( 2221): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-17 20:14:46.522+0900 D/W_HOME  ( 2221): main.c: _resume_cb(564) > Resumed
03-17 20:14:46.522+0900 E/W_HOME  ( 2221): main.c: _resume_cb(567) > resumed already
03-17 20:14:46.522+0900 D/LAUNCH  ( 2221): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
03-17 20:14:46.522+0900 D/LAUNCH  ( 2221): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
03-17 20:14:46.522+0900 D/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-17 20:14:46.522+0900 E/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-17 20:14:46.522+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=10
03-17 20:14:46.522+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_resume
03-17 20:14:46.522+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1291) > ##### mc_resume
03-17 20:14:46.522+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2221 is resumed
03-17 20:14:46.522+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
03-17 20:14:48.732+0900 W/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(463) > [_notify_pm_lcdoff_cb:463] LCD OFF by lcd off source[2], wake_up_setting[1], ALPM_clock_state[0]
03-17 20:14:48.732+0900 E/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(482) > [_notify_pm_lcdoff_cb:482] Failed to get [memory/setup_wizard/state]
03-17 20:14:48.732+0900 W/STARTER ( 2215): clock-mgr.c: _check_reserved_popup_status(93) > [_check_reserved_popup_status:93] Current reserved apps status : 0
03-17 20:14:48.732+0900 W/STARTER ( 2215): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
03-17 20:14:48.732+0900 E/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(666) > [_notify_pm_lcdoff_cb:666] Failed to get VCONFKEY_SETTING_SIMPLE_CLOCK_MODE
03-17 20:14:48.732+0900 W/STARTER ( 2215): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
03-17 20:14:48.732+0900 W/STARTER ( 2215): clock-mgr.c: _notify_pm_lcdoff_cb(674) > [_notify_pm_lcdoff_cb:674] Not reserved apss status AND wake_up_setting is CLOCK => show simple clock..!!
03-17 20:14:48.732+0900 E/STARTER ( 2215): dbus-util_w.c: _dbus_message_send(149) > [_dbus_message_send:149] dbus_message_new_signal(/Org/Tizen/Coreapps/starter:org.tizen.coreapps.starter.alpmclock-show)
03-17 20:14:48.732+0900 D/STARTER ( 2215): dbus-util_w.c: _dbus_message_send(163) > [_dbus_message_send:163] dbus_connection_send, ret=1
03-17 20:14:48.732+0900 E/STARTER ( 2215): dbus-util_w.c: starter_dbus_alpm_clock_signal_send(187) > [starter_dbus_alpm_clock_signal_send:187] Sending alpmclock show signal, result:0
03-17 20:14:48.732+0900 E/AUL_AMD ( 2100): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
03-17 20:14:48.732+0900 D/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
03-17 20:14:48.732+0900 W/STARTER ( 2215): dbus-util_w.c: _on_lcd_changed_receive(632) > [_on_lcd_changed_receive:632] LCD off
03-17 20:14:48.732+0900 W/W_HOME  ( 2221): dbus.c: _dbus_message_recv_cb(190) > LCD on
03-17 20:14:48.732+0900 E/W_HOME  ( 2221): dbus.c: _dbus_message_recv_cb(197) > Failed to get reply (org.freedesktop.DBus.Error.InvalidArgs:Argument 0 is specified to be of type "string", but is actually of type "invalid"
03-17 20:14:48.732+0900 E/W_HOME  ( 2221): )
03-17 20:14:48.732+0900 D/W_HOME  ( 2221): main.c: _lcd_off_cb(967) > LCD: on->off
03-17 20:14:48.732+0900 W/W_HOME  ( 2221): main.c: _lcd_off_cb(970) > clock/widget paused
03-17 20:14:48.732+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-17 20:14:48.732+0900 D/W_HOME  ( 2221): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb939c8a0 is paused
03-17 20:14:48.742+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
03-17 20:14:48.742+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
03-17 20:14:48.742+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
03-17 20:14:48.752+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2221 is paused
03-17 20:14:48.752+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-17 20:14:48.852+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [2]
03-17 20:14:48.852+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-17 20:14:48.852+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 3[0;m
03-17 20:14:48.852+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-17 20:14:48.852+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:3,lock_state:0[0;m
03-17 20:14:48.852+0900 D/W_HOME  ( 2221): clock_event.c: _display_state_cb(197) > LCD: on->off
03-17 20:14:48.852+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:40001 received
03-17 20:14:48.852+0900 D/W_HOME  ( 2221): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:0, is_need_vi:0
03-17 20:14:49.362+0900 D/NET_NFC_MANAGER( 2246): net_nfc_server_common.c: restart_polling_loop_thread_func(484) > [0;35mpolling disabled[0;m
03-17 20:14:50.222+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: main(1436) > server start
03-17 20:14:50.222+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: main(1505) > Main loop is created.
03-17 20:14:50.222+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(144) > called
03-17 20:14:50.222+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(155) > done
03-17 20:14:50.222+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkg_mgr_object_init(93) > called
03-17 20:14:50.222+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > RequestName returns: 1
03-17 20:14:50.222+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkg_mgr_object_init(135) > Ready to serve requests
03-17 20:14:50.232+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkg_mgr_object_init(139) > done
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: main(1510) > pkg_mgr object is created, and request callback is registered.
03-17 20:14:50.232+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkgmgr_request(194) > Called
03-17 20:14:50.232+0900 D/PKGMGR  (24107): comm_pkg_mgr_server.c: pkgmgr_request(203) > [SECURE_LOG] Call request callback(obj, org.exelim.flyingbird_-1121217809, 11, rpm, org.exelim.flyingbird, , *ret)
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: req_cb(431) > [SECURE_LOG] >> in callback >> Got request: [org.exelim.flyingbird_-1121217809] [11] [rpm] [org.exelim.flyingbird] [] []
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: __register_signal_handler(382) > signal: SIGCHLD succeed
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: __register_signal_handler(384) > g_timeout_add_seconds() Added to Main Loop
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: req_cb(450) > req_type=(11)  backend_flag=(0)
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: queue_job(1168) > saved queue status. Now try fork()
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: queue_job(1175) > child forked [24108] for request type [11]
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: queue_job(1347) > parent exit
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24108): pkgmgr-server.c: queue_job(1175) > child forked [0] for request type [11]
03-17 20:14:50.232+0900 D/PKGMGR_SERVER(24108): pkgmgr-server.c: __make_pid_info_file(825) > File path = /tmp/org.exelim.flyingbird
03-17 20:14:50.262+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: sighandler(326) > child exit [24108]
03-17 20:14:50.262+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: sighandler(341) > child NORMAL exit [24108]
03-17 20:14:51.992+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: exit_server(724) > exit_server Start
03-17 20:14:51.992+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: main(1516) > Quit main loop.
03-17 20:14:51.992+0900 D/PKGMGR_SERVER(24107): pkgmgr-server.c: main(1524) > package manager server terminated.
03-17 20:14:53.332+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(495) > __request_handler: 0
03-17 20:14:53.332+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(540) > launch a single-instance appid: org.exelim.flyingbird
03-17 20:14:53.332+0900 D/AUL     ( 2100): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 24160, pid = 24162
03-17 20:14:53.332+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-17 20:14:53.332+0900 D/AUL_AMD ( 2100): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-17 20:14:53.332+0900 D/AUL     ( 2100): app_sock.c: __app_send_raw(265) > pid(-4) : cmd(0)
03-17 20:14:53.442+0900 E/AUL_PAD ( 2122): launchpad.c: __launchpad_main_loop(1177) > faild to get app pid
03-17 20:14:53.442+0900 D/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-17 20:14:53.442+0900 E/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(264) > access
03-17 20:14:53.442+0900 D/RESOURCED( 2344): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-17 20:14:53.442+0900 D/RESOURCED( 2344): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2100
03-17 20:14:53.442+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.exelim.flyingbird, pid 24163, type 4 
03-17 20:14:53.442+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.exelim.flyingbird, 24163
03-17 20:14:53.442+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.exelim.flyingbird with pkgname
03-17 20:14:53.442+0900 E/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 356
03-17 20:14:53.442+0900 D/RESOURCED( 2344): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-17 20:14:54.442+0900 D/AUL_AMD ( 2100): amd_launch.c: __grab_timeout_handler(1212) > pid(24163) ecore_x_pointer_ungrab
03-17 20:14:54.442+0900 D/AUL_AMD ( 2100): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.exelim.flyingbird /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
03-17 20:14:54.442+0900 D/RUA     ( 2100): rua.c: rua_add_history(179) > rua_add_history start
03-17 20:14:54.442+0900 D/RUA     ( 2100): rua.c: rua_add_history(247) > rua_add_history ok
03-17 20:14:54.602+0900 I/efl-extension(24165): efl_extension.c: eext_mod_init(39) > Init
03-17 20:14:54.612+0900 D/AUL     (24165): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 24165 is org.exelim.flyingbird
03-17 20:14:54.612+0900 I/CAPI_APPFW_APPLICATION(24165): app_main.c: ui_app_main(701) > app_efl_main
03-17 20:14:54.612+0900 D/LAUNCH  (24165): appcore-efl.c: appcore_efl_main(1571) > [flyingbird:Application:main:done]
03-17 20:14:54.612+0900 D/AUL     (24165): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 24165 is org.exelim.flyingbird
03-17 20:14:54.762+0900 D/APP_CORE(24165): appcore-efl.c: __before_loop(1012) > elm_config_preferred_engine_set : opengl_x11
03-17 20:14:54.762+0900 D/AUL     (24165): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 24165 is org.exelim.flyingbird
03-17 20:14:54.762+0900 D/APP_CORE(24165): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.exelim.flyingbird/res/locale
03-17 20:14:54.762+0900 D/APP_CORE(24165): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-17 20:14:54.762+0900 D/AUL     (24165): app_sock.c: __create_server_sock(136) > pg path - already exists
03-17 20:14:54.762+0900 D/LAUNCH  (24165): appcore-efl.c: __before_loop(1035) > [flyingbird:Platform:appcore_init:done]
03-17 20:14:54.762+0900 I/CAPI_APPFW_APPLICATION(24165): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-17 20:14:55.212+0900 D/W_HOME  ( 2221): main.c: _window_focus_out_cb(869) > focus out
03-17 20:14:55.212+0900 D/W_HOME  ( 2221): main.c: _pause_cb(600) > Paused
03-17 20:14:55.212+0900 D/W_HOME  ( 2221): page.c: page_focus(701) > focus set to 0xb94374f8
03-17 20:14:55.212+0900 W/W_HOME  ( 2221): main.c: _pause_cb(613) > clock/widget paused
03-17 20:14:55.212+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-17 20:14:55.212+0900 E/APPS    ( 2221): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
03-17 20:14:55.222+0900 D/LAUNCH  (24165): appcore-efl.c: __before_loop(1047) > [flyingbird:Application:create:done]
03-17 20:14:55.222+0900 D/APP_CORE(24165): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-17 20:14:55.222+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2221 is paused
03-17 20:14:55.222+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-17 20:14:55.222+0900 D/APP_CORE(24165): appcore.c: __aul_handler(423) > [APP 24165]     AUL event: AUL_START
03-17 20:14:55.222+0900 D/APP_CORE(24165): appcore-efl.c: __do_app(470) > [APP 24165] Event: RESET State: CREATED
03-17 20:14:55.222+0900 D/APP_CORE(24165): appcore-efl.c: __do_app(496) > [APP 24165] RESET
03-17 20:14:55.222+0900 D/LAUNCH  (24165): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
03-17 20:14:55.222+0900 I/CAPI_APPFW_APPLICATION(24165): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-17 20:14:55.222+0900 D/APP_SVC (24165): appsvc.c: __set_bundle(161) > __set_bundle
03-17 20:14:55.222+0900 D/LAUNCH  (24165): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
03-17 20:14:55.222+0900 E/PKGMGR_INFO(24165): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1327) > (appid == NULL) appid is NULL
03-17 20:14:55.222+0900 I/APP_CORE(24165): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-17 20:14:55.222+0900 I/APP_CORE(24165): appcore-efl.c: __do_app(509) > [APP 24165] Initial Launching, call the resume_cb
03-17 20:14:55.222+0900 I/CAPI_APPFW_APPLICATION(24165): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-17 20:14:55.222+0900 D/APP_CORE(24165): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-17 20:14:55.222+0900 D/APP_CORE(24165): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00003
03-17 20:14:55.222+0900 D/APP_CORE(24165): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00003
03-17 20:14:55.232+0900 D/AUL     (24165): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 24165 is org.exelim.flyingbird
03-17 20:15:00.772+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-17 20:15:00.772+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-17 20:15:00.772+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(clock_font_color) error
03-17 20:15:00.772+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-17 20:15:00.772+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-17 20:15:00.772+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2229): preference.c: preference_get_int(1063) > preference_get_int(2229) : key(showdate) error
03-17 20:15:00.772+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-17 20:15:00.772+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Thu 17 Mar][1458213300]
03-17 20:15:00.772+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(857) > 
03-17 20:15:00.772+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1458213300]
03-17 20:15:00.772+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[8:15][1458213300]
03-17 20:15:00.772+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(871) > utc_time=8:15, utc_ampm=[2]PM
03-17 20:15:00.772+0900 D/IDLE-CLOCK-DIGITAL( 2229): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>8:15<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
03-17 20:15:05.252+0900 W/W_HOME  ( 2221): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
03-17 20:15:05.252+0900 D/APP_CORE( 2221): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
03-17 20:15:05.252+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-17 20:15:05.252+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-17 20:15:05.252+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(470) > [APP 2221] Event: PAUSE State: RUNNING
03-17 20:15:05.252+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(538) > [APP 2221] PAUSE
03-17 20:15:05.252+0900 I/CAPI_APPFW_APPLICATION( 2221): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-17 20:15:05.252+0900 D/W_HOME  ( 2221): main.c: _pause_cb(600) > Paused
03-17 20:15:05.252+0900 E/W_HOME  ( 2221): main.c: _pause_cb(603) > paused already
03-17 20:15:05.252+0900 D/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-17 20:15:05.252+0900 E/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-17 20:15:05.252+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2221, type = 2
03-17 20:15:05.262+0900 D/AUL_AMD ( 2100): amd_launch.c: __e17_status_handler(1911) > pid(24165) status(3)
03-17 20:15:05.262+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 24165, type = 0
03-17 20:15:05.262+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 24165
03-17 20:15:05.262+0900 E/RESOURCED( 2344): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (24165) didn't have any process list
03-17 20:15:05.262+0900 D/RESOURCED( 2344): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 24165, appname = (null)
03-17 20:15:05.262+0900 D/RESOURCED( 2344): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 24165
03-17 20:15:10.322+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(470) > [APP 2221] Event: MEM_FLUSH State: PAUSED
03-17 20:15:11.222+0900 E/RESOURCED( 2344): proc-monitor.c: edbus_signal_trigger(467) > [edbus_signal_trigger,467] Receive watchdog signal to pid: 24165(flyingbird)
03-17 20:15:11.412+0900 D/AUL_AMD ( 2100): amd_launch.c: __e17_status_handler(1911) > pid(2221) status(3)
03-17 20:15:11.412+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2221, type = 0
03-17 20:15:11.412+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2221
03-17 20:15:11.412+0900 D/RESOURCED( 2344): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2221, appname = (null)
03-17 20:15:11.412+0900 D/RESOURCED( 2344): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2221
03-17 20:15:11.482+0900 D/W_HOME  ( 2221): main.c: _window_focus_in_cb(848) > focus in
03-17 20:15:11.482+0900 D/W_HOME  ( 2221): main.c: _resume_cb(564) > Resumed
03-17 20:15:11.482+0900 D/APPS    ( 2221): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
03-17 20:15:11.482+0900 D/W_HOME  ( 2221): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
03-17 20:15:11.482+0900 E/efl-extension( 2221): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb931f320, elm_scroller, _activated_obj : 0xb931f320, activated : 1
03-17 20:15:11.482+0900 E/APPS    ( 2221): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
03-17 20:15:11.482+0900 W/W_HOME  ( 2221): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(0)
03-17 20:15:11.482+0900 D/APP_CORE( 2221): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 0
03-17 20:15:11.482+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
03-17 20:15:11.482+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-17 20:15:14.512+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: main(1436) > server start
03-17 20:15:14.522+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: main(1505) > Main loop is created.
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(144) > called
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(155) > done
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkg_mgr_object_init(93) > called
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > RequestName returns: 1
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkg_mgr_object_init(135) > Ready to serve requests
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkg_mgr_object_init(139) > done
03-17 20:15:14.522+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: main(1510) > pkg_mgr object is created, and request callback is registered.
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkgmgr_request(194) > Called
03-17 20:15:14.522+0900 D/PKGMGR  (24205): comm_pkg_mgr_server.c: pkgmgr_request(203) > [SECURE_LOG] Call request callback(obj, org.exelim.flyingbird_-1096920987, 11, rpm, org.exelim.flyingbird, , *ret)
03-17 20:15:14.522+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: req_cb(431) > [SECURE_LOG] >> in callback >> Got request: [org.exelim.flyingbird_-1096920987] [11] [rpm] [org.exelim.flyingbird] [] []
03-17 20:15:14.522+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: __register_signal_handler(382) > signal: SIGCHLD succeed
03-17 20:15:14.522+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: __register_signal_handler(384) > g_timeout_add_seconds() Added to Main Loop
03-17 20:15:14.522+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: req_cb(450) > req_type=(11)  backend_flag=(0)
03-17 20:15:14.532+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: queue_job(1168) > saved queue status. Now try fork()
03-17 20:15:14.532+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: queue_job(1175) > child forked [24206] for request type [11]
03-17 20:15:14.532+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: queue_job(1347) > parent exit
03-17 20:15:14.532+0900 D/PKGMGR_SERVER(24206): pkgmgr-server.c: queue_job(1175) > child forked [0] for request type [11]
03-17 20:15:14.542+0900 D/PKGMGR_SERVER(24206): pkgmgr-server.c: __make_pid_info_file(825) > File path = /tmp/org.exelim.flyingbird
03-17 20:15:14.542+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: sighandler(326) > child exit [24206]
03-17 20:15:14.542+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: sighandler(341) > child NORMAL exit [24206]
03-17 20:15:16.992+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: exit_server(724) > exit_server Start
03-17 20:15:16.992+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: main(1516) > Quit main loop.
03-17 20:15:16.992+0900 D/PKGMGR_SERVER(24205): pkgmgr-server.c: main(1524) > package manager server terminated.
03-17 20:15:17.752+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(495) > __request_handler: 0
03-17 20:15:17.752+0900 D/AUL_AMD ( 2100): amd_request.c: __request_handler(540) > launch a single-instance appid: org.exelim.flyingbird
03-17 20:15:17.752+0900 D/AUL     ( 2100): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 24258, pid = 24260
03-17 20:15:17.752+0900 D/AUL_AMD ( 2100): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-17 20:15:17.752+0900 D/AUL_AMD ( 2100): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-17 20:15:17.752+0900 D/AUL     ( 2100): app_sock.c: __app_send_raw(265) > pid(-4) : cmd(0)
03-17 20:15:17.852+0900 E/AUL_PAD ( 2122): launchpad.c: __launchpad_main_loop(1177) > faild to get app pid
03-17 20:15:17.852+0900 D/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-17 20:15:17.852+0900 E/AUL     ( 2100): simple_util.c: __trm_app_info_send_socket(264) > access
03-17 20:15:17.852+0900 D/RESOURCED( 2344): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-17 20:15:17.852+0900 D/RESOURCED( 2344): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2100
03-17 20:15:17.852+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.exelim.flyingbird, pid 24261, type 4 
03-17 20:15:17.852+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.exelim.flyingbird, 24261
03-17 20:15:17.852+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.exelim.flyingbird with pkgname
03-17 20:15:17.852+0900 E/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 357
03-17 20:15:17.852+0900 D/RESOURCED( 2344): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-17 20:15:18.852+0900 D/AUL_AMD ( 2100): amd_launch.c: __grab_timeout_handler(1212) > pid(24261) ecore_x_pointer_ungrab
03-17 20:15:18.852+0900 D/AUL_AMD ( 2100): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.exelim.flyingbird /opt/usr/apps/org.exelim.flyingbird/bin/flyingbird
03-17 20:15:18.852+0900 D/RUA     ( 2100): rua.c: rua_add_history(179) > rua_add_history start
03-17 20:15:18.862+0900 D/RUA     ( 2100): rua.c: rua_add_history(247) > rua_add_history ok
03-17 20:15:18.932+0900 I/efl-extension(24263): efl_extension.c: eext_mod_init(39) > Init
03-17 20:15:18.932+0900 D/AUL     (24263): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 24263 is org.exelim.flyingbird
03-17 20:15:18.932+0900 I/CAPI_APPFW_APPLICATION(24263): app_main.c: ui_app_main(701) > app_efl_main
03-17 20:15:18.932+0900 D/LAUNCH  (24263): appcore-efl.c: appcore_efl_main(1571) > [flyingbird:Application:main:done]
03-17 20:15:18.942+0900 D/AUL     (24263): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 24263 is org.exelim.flyingbird
03-17 20:15:19.092+0900 D/APP_CORE(24263): appcore-efl.c: __before_loop(1012) > elm_config_preferred_engine_set : opengl_x11
03-17 20:15:19.092+0900 D/AUL     (24263): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 24263 is org.exelim.flyingbird
03-17 20:15:19.092+0900 D/APP_CORE(24263): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.exelim.flyingbird/res/locale
03-17 20:15:19.092+0900 D/APP_CORE(24263): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-17 20:15:19.092+0900 D/AUL     (24263): app_sock.c: __create_server_sock(136) > pg path - already exists
03-17 20:15:19.092+0900 D/LAUNCH  (24263): appcore-efl.c: __before_loop(1035) > [flyingbird:Platform:appcore_init:done]
03-17 20:15:19.092+0900 I/CAPI_APPFW_APPLICATION(24263): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-17 20:15:19.562+0900 D/W_HOME  ( 2221): main.c: _window_focus_out_cb(869) > focus out
03-17 20:15:19.562+0900 D/W_HOME  ( 2221): main.c: _pause_cb(600) > Paused
03-17 20:15:19.562+0900 D/W_HOME  ( 2221): page.c: page_focus(701) > focus set to 0xb94374f8
03-17 20:15:19.562+0900 W/W_HOME  ( 2221): main.c: _pause_cb(613) > clock/widget paused
03-17 20:15:19.562+0900 D/W_HOME  ( 2221): clock_view.c: clock_view_event_handler(843) > event:10002 received
03-17 20:15:19.562+0900 E/APPS    ( 2221): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
03-17 20:15:19.572+0900 D/LAUNCH  (24263): appcore-efl.c: __before_loop(1047) > [flyingbird:Application:create:done]
03-17 20:15:19.572+0900 D/APP_CORE(24263): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-17 20:15:19.572+0900 D/APP_CORE(24263): appcore.c: __aul_handler(423) > [APP 24263]     AUL event: AUL_START
03-17 20:15:19.572+0900 D/APP_CORE(24263): appcore-efl.c: __do_app(470) > [APP 24263] Event: RESET State: CREATED
03-17 20:15:19.572+0900 D/APP_CORE(24263): appcore-efl.c: __do_app(496) > [APP 24263] RESET
03-17 20:15:19.572+0900 D/LAUNCH  (24263): appcore-efl.c: __do_app(498) > [flyingbird:Application:reset:start]
03-17 20:15:19.572+0900 I/CAPI_APPFW_APPLICATION(24263): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-17 20:15:19.572+0900 D/APP_SVC (24263): appsvc.c: __set_bundle(161) > __set_bundle
03-17 20:15:19.572+0900 D/LAUNCH  (24263): appcore-efl.c: __do_app(501) > [flyingbird:Application:reset:done]
03-17 20:15:19.572+0900 E/PKGMGR_INFO(24263): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1327) > (appid == NULL) appid is NULL
03-17 20:15:19.572+0900 I/APP_CORE(24263): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-17 20:15:19.572+0900 I/APP_CORE(24263): appcore-efl.c: __do_app(509) > [APP 24263] Initial Launching, call the resume_cb
03-17 20:15:19.572+0900 I/CAPI_APPFW_APPLICATION(24263): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-17 20:15:19.572+0900 D/APP_CORE(24263): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-17 20:15:19.572+0900 D/APP_CORE(24263): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00003
03-17 20:15:19.572+0900 D/APP_CORE(24263): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00003
03-17 20:15:19.572+0900 D/DATA_PROVIDER_MASTER( 2243): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2221 is paused
03-17 20:15:19.572+0900 D/DATA_PROVIDER_MASTER( 2243): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-17 20:15:19.572+0900 D/AUL     (24263): pkginfo.c: aul_app_get_appid_bypid(196) > [SECURE_LOG] appid for 24263 is org.exelim.flyingbird
03-17 20:15:29.571+0900 W/W_HOME  ( 2221): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
03-17 20:15:29.571+0900 D/APP_CORE( 2221): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
03-17 20:15:29.571+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-17 20:15:29.571+0900 D/APP_CORE( 2221): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-17 20:15:29.571+0900 D/APP_CORE( 2221): appcore-efl.c: __do_app(470) > [APP 2221] Event: PAUSE State: PAUSED
03-17 20:15:29.571+0900 D/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-17 20:15:29.571+0900 E/APP_CORE( 2221): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-17 20:15:29.571+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2221, type = 2
03-17 20:15:29.571+0900 D/AUL_AMD ( 2100): amd_launch.c: __e17_status_handler(1911) > pid(24263) status(3)
03-17 20:15:29.571+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 24263, type = 0
03-17 20:15:29.571+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 24263
03-17 20:15:29.571+0900 E/RESOURCED( 2344): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (24263) didn't have any process list
03-17 20:15:29.571+0900 D/RESOURCED( 2344): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 24263, appname = (null)
03-17 20:15:29.571+0900 D/RESOURCED( 2344): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 24263
03-17 20:15:35.571+0900 E/RESOURCED( 2344): proc-monitor.c: edbus_signal_trigger(467) > [edbus_signal_trigger,467] Receive watchdog signal to pid: 24263(flyingbird)
03-17 20:28:13.512+0900 D/AUL_AMD ( 2100): amd_launch.c: __e17_status_handler(1911) > pid(2221) status(3)
03-17 20:28:13.512+0900 D/RESOURCED( 2344): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2221, type = 0
03-17 20:28:13.512+0900 D/RESOURCED( 2344): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2221
03-17 20:28:13.512+0900 D/RESOURCED( 2344): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2221, appname = (null)
03-17 20:28:13.512+0900 D/RESOURCED( 2344): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2221
03-17 20:28:13.622+0900 D/W_HOME  ( 2221): main.c: _window_focus_in_cb(848) > focus in
03-17 20:28:13.622+0900 D/W_HOME  ( 2221): main.c: _resume_cb(564) > Resumed
03-17 20:28:13.622+0900 D/APPS    ( 2221): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
03-17 20:28:13.622+0900 D/W_HOME  ( 2221): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
03-17 20:28:13.622+0900 E/efl-extension( 2221): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb931f320, elm_scroller, _activated_obj : 0xb931f320, activated : 1
03-17 20:28:13.622+0900 E/APPS    ( 2221): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
03-17 20:28:13.622+0900 W/CRASH_MANAGER(24267): worker.c: worker_job(1189) > 1124263666c79145821409
