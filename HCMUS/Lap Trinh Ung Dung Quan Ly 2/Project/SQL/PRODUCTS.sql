﻿-- Tạo bảng lưu thông tin sản phẩm
CREATE TABLE PRODUCTS (
    products_code int PRIMARY KEY,       -- Mã hàng là khóa chính
    category_id int NOT NULL,         -- Loại xe (Mô tô phân khối lớn, nhỏ, hoặc xe máy)
    products_name NVARCHAR(MAX) NOT NULL,       -- Tên hàng
    products_des NVARCHAR(MAX) NOT NULL,          -- Mô tả sản phẩm
    products_iamge NVARCHAR(255),                -- Đường dẫn đến hình ảnh
    products_year VARCHAR NOT NULL               -- Năm sản xuất
);

-- Chèn dữ liệu mẫu (66 dòng)
--INSERT INTO SanPham (MaHang, LoaiXe, TenHang, MoTa, HinhAnh, NamSanXuat) VALUES
--(1, 'Mô tô phân khối lớn', N'Honda Goldwing', 'Dung tích xylanh: 1833cc. Touring, hệ thống âm thanh và định vị cao cấp.', '/images/honda_goldwing.jpg', 2023),
--(2, 'Mô tô phân khối lớn', N'Harley-Davidson Fat Boy', 'Dung tích xylanh: 1745cc. Cruiser, phong cách cổ điển, động cơ Milwaukee-Eight 107.', '/images/harley_fatboy.jpg', 2022),
--(3, 'Mô tô phân khối lớn', N'BMW R1250GS', 'Dung tích xylanh: 1254cc. Adventure, hệ thống treo Dynamic ESA.', '/images/bmw_r1250gs.jpg', 2023),
--(4, 'Mô tô phân khối lớn', N'Kawasaki Z H2', 'Dung tích xylanh: 998cc. Naked Bike, động cơ siêu nạp, phanh Brembo.', '/images/kawasaki_zh2.jpg', 2023),
--(5, 'Mô tô phân khối lớn', N'Yamaha YZF-R1', 'Dung tích xylanh: 998cc. Sportbike, công nghệ Quick Shift và Launch Control.', '/images/yamaha_r1.jpg', 2023),
--(6, 'Mô tô phân khối lớn', N'Ducati Panigale V4', 'Dung tích xylanh: 1103cc. Sportbike, động cơ Desmosedici Stradale, công nghệ Cornering ABS.', '/images/ducati_panigale.jpg', 2023),
--(7, 'Mô tô phân khối lớn', N'Suzuki Hayabusa', 'Dung tích xylanh: 1340cc. Sport-touring, tốc độ tối đa lên đến 300km/h.', '/images/suzuki_hayabusa.jpg', 2023),
--(8, 'Mô tô phân khối lớn', N'Triumph Rocket 3 R', 'Dung tích xylanh: 2458cc. Roadster, mô-men xoắn cao nhất phân khúc.', '/images/triumph_rocket3.jpg', 2023),
--(9, 'Mô tô phân khối lớn', N'Honda Africa Twin', 'Dung tích xylanh: 1084cc. Adventure, hệ thống kiểm soát mô-men xoắn HSTC.', '/images/honda_africa_twin.jpg', 2023),
--(10, 'Mô tô phân khối lớn', N'KTM 1290 Super Duke R', 'Dung tích xylanh: 1301cc. Naked Bike, công suất 177 mã lực, khung xe nhẹ.', '/images/ktm_1290_duke.jpg', 2023),
--(11, 'Mô tô phân khối nhỏ', N'Yamaha YZF-R3', 'Dung tích xylanh: 321cc. Sportbike, động cơ DOHC, phuộc upside-down.', '/images/yamaha_r3.jpg', 2022),
--(12, 'Mô tô phân khối nhỏ', N'Kawasaki Ninja 400', 'Dung tích xylanh: 399cc. Sportbike, động cơ 4 thì, phuộc Showa.', '/images/kawasaki_ninja400.jpg', 2022),
--(13, 'Mô tô phân khối nhỏ', N'Honda CBR500R', 'Dung tích xylanh: 471cc. Sportbike, động cơ DOHC, thiết kế khí động học.', '/images/honda_cbr500r.jpg', 2023),
--(14, 'Mô tô phân khối nhỏ', N'KTM RC390', 'Dung tích xylanh: 373cc. Sportbike, động cơ một xy lanh, phuộc WP Apex.', '/images/ktm_rc390.jpg', 2023),
--(15, 'Mô tô phân khối nhỏ', N'Yamaha MT-03', 'Dung tích xylanh: 321cc. Naked bike, hệ thống phanh ABS, thiết kế thể thao.', '/images/yamaha_mt03.jpg', 2023),
--(16, 'Mô tô phân khối nhỏ', N'Suzuki GSX250R', 'Dung tích xylanh: 248cc. Sportbike, thiết kế khí động học, động cơ 2 xy lanh.', '/images/suzuki_gsx250r.jpg', 2023),
--(17, 'Mô tô phân khối nhỏ', N'BMW G310R', 'Dung tích xylanh: 313cc. Naked bike, động cơ xi-lanh đơn, công nghệ phuộc upside-down.', '/images/bmw_g310r.jpg', 2023),
--(18, 'Mô tô phân khối nhỏ', N'Kawasaki Z400', 'Dung tích xylanh: 399cc. Naked bike, động cơ DOHC, hệ thống điều chỉnh phuộc.', '/images/kawasaki_z400.jpg', 2022),
--(19, 'Mô tô phân khối nhỏ', N'Honda CB500F', 'Dung tích xylanh: 471cc. Naked bike, hệ thống kiểm soát phanh ABS.', '/images/honda_cb500f.jpg', 2023),
--(20, 'Mô tô phân khối nhỏ', N'Yamaha FZ25', 'Dung tích xylanh: 249cc. Naked bike, thiết kế thể thao và động cơ mạnh mẽ.', '/images/yamaha_fz25.jpg', 2023),
--(21, 'Mô tô phân khối nhỏ', N'TVS Apache RR 310', 'Dung tích xylanh: 312cc. Sportbike, động cơ DOHC, hệ thống chống trượt.', '/images/tvs_apache_rr310.jpg', 2023),
--(22, 'Mô tô phân khối nhỏ', N'Bajaj Pulsar NS200', 'Dung tích xylanh: 199cc. Naked bike, hệ thống kiểm soát phanh CBS.', '/images/bajaj_pulsar_ns200.jpg', 2023),
--(23, 'Xe máy', 'Honda Vision', N'Dung tích xylanh: 110cc. Xe máy tay ga, động cơ tiết kiệm nhiên liệu, thiết kế thanh lịch.', '/images/honda_vision.jpg', 2023),
--(24, 'Xe máy', 'Yamaha Janus', N'Dung tích xylanh: 125cc. Xe máy tay ga, công nghệ Blue Core, hệ thống phun xăng điện tử.', '/images/yamaha_janus.jpg', 2023),
--(25, 'Xe máy', 'Honda Lead', N'Dung tích xylanh: 125cc. Xe máy tay ga, công nghệ Smart Key, thiết kế sang trọng.', '/images/honda_lead.jpg', 2023),
--(26, 'Xe máy', 'Suzuki Address', N'Dung tích xylanh: 113cc. Xe máy tay ga, tiết kiệm nhiên liệu, động cơ 4 thì.', '/images/suzuki_address.jpg', 2023),
--(27, 'Xe máy', 'Vespa Primavera', N'Dung tích xylanh: 155cc. Xe tay ga, thiết kế cổ điển, động cơ phun xăng điện tử.', '/images/vespa_primavera.jpg', 2023),
--(28, 'Xe máy', 'Piaggio Liberty', N'Dung tích xylanh: 125cc. Xe tay ga, công nghệ phun xăng điện tử, thiết kế nhẹ nhàng.', '/images/piaggio_liberty.jpg', 2023),
--(29, 'Xe máy', 'Honda Air Blade', N'Dung tích xylanh: 125cc. Xe máy tay ga, động cơ mạnh mẽ, tiết kiệm nhiên liệu.', '/images/honda_airblade.jpg', 2023),
--(30, 'Xe máy', 'Yamaha Exciter 150', N'Dung tích xylanh: 150cc. Xe côn tay, thiết kế thể thao, công nghệ Fi.', '/images/yamaha_exciter150.jpg', 2023),
--(31, 'Xe máy', 'Suzuki Raider R150', N'Dung tích xylanh: 150cc. Xe côn tay, động cơ mạnh mẽ, thiết kế thể thao.', '/images/suzuki_raider.jpg', 2023),
--(32, 'Xe máy', 'Honda CBR150R', N'Dung tích xylanh: 150cc. Sportbike, động cơ DOHC, hệ thống phuộc upside-down.', '/images/honda_cbr150r.jpg', 2023),
--(33, 'Xe máy', 'KTM RC200', N'Dung tích xylanh: 199cc. Sportbike, động cơ DOHC, thiết kế khí động học.', '/images/ktm_rc200.jpg', 2023),
--(34, 'Xe máy', 'Yamaha YZF-R15', N'Dung tích xylanh: 155cc. Sportbike, động cơ SOHC, thiết kế thể thao.', '/images/yamaha_r15.jpg', 2023),
--(35, 'Xe máy', 'Kawasaki Ninja 250', N'Dung tích xylanh: 250cc. Sportbike, động cơ DOHC, thiết kế khí động học.', '/images/kawasaki_ninja250.jpg', 2023),
--(36, 'Xe máy', 'Honda CBR250R', N'Dung tích xylanh: 250cc. Sportbike, động cơ DOHC, hệ thống chống trượt.', '/images/honda_cbr250r.jpg', 2023),
--(37, 'Xe máy', 'Yamaha FZ150i', N'Dung tích xylanh: 150cc. Naked bike, động cơ 4 thì, phuộc giảm chấn hiệu suất cao.', '/images/yamaha_fz150i.jpg', 2023),
--(38, 'Xe máy', 'Bajaj Pulsar 150', N'Dung tích xylanh: 150cc. Naked bike, thiết kế mạnh mẽ, tiết kiệm nhiên liệu.', '/images/bajaj_pulsar150.jpg', 2023),
--(39, 'Xe máy', 'Suzuki GSX-R150', N'Dung tích xylanh: 150cc. Sportbike, thiết kế khí động học, hệ thống phanh đĩa kép.', '/images/suzuki_gsxr150.jpg', 2023),
--(40, 'Xe máy', 'Yamaha MT-15', N'Dung tích xylanh: 155cc. Naked bike, động cơ mạnh mẽ, thiết kế hiện đại.', '/images/yamaha_mt15.jpg', 2023),
--(41, 'Xe máy', 'Honda CBR1000RR', N'Dung tích xylanh: 1000cc. Sportbike, công suất 190 mã lực, hệ thống điện tử nâng cao.', '/images/honda_cbr1000rr.jpg', 2023),
--(42, 'Xe máy', 'Kawasaki Z1000', N'Dung tích xylanh: 1043cc. Naked bike, thiết kế hầm hố, động cơ 4 thì.', '/images/kawasaki_z1000.jpg', 2023),
--(43, 'Xe máy', 'Yamaha YZF-R6', N'Dung tích xylanh: 599cc. Sportbike, động cơ 4 thì, thiết kế khí động học.', '/images/yamaha_r6.jpg', 2023),
--(44, 'Xe máy', 'Suzuki V-Strom 650', N'Dung tích xylanh: 645cc. Adventure, phuộc hành trình dài, động cơ 2 xy lanh.', '/images/suzuki_vstrom650.jpg', 2023),
--(45, 'Xe máy', 'Honda CB650R', N'Dung tích xylanh: 649cc. Naked bike, động cơ mạnh mẽ, thiết kế thanh lịch.', '/images/honda_cb650r.jpg', 2023),
--(46, 'Xe máy', 'BMW S1000RR', N'Dung tích xylanh: 999cc. Sportbike, động cơ mạnh mẽ, hệ thống treo điều chỉnh điện.', '/images/bmw_s1000rr.jpg', 2023),
--(47, 'Xe máy', 'KTM 390 Duke', N'Dung tích xylanh: 373cc. Naked bike, động cơ DOHC, thiết kế hiện đại.', '/images/ktm_390duke.jpg', 2023),
--(48, 'Xe máy', 'Honda CRF250L', N'Dung tích xylanh: 249cc. Enduro, hệ thống treo cao cấp, động cơ tiết kiệm nhiên liệu.', '/images/honda_crf250l.jpg', 2023),
--(49, 'Xe máy', 'Kawasaki Versys-X 300', N'Dung tích xylanh: 296cc. Adventure, hệ thống kiểm soát mô-men xoắn.', '/images/kawasaki_versysx300.jpg', 2023),
--(50, 'Xe máy', 'Yamaha MT-09', N'Dung tích xylanh: 847cc. Naked bike, công suất 115 mã lực, hệ thống phuộc hành trình dài.', '/images/yamaha_mt09.jpg', 2023),
--(51, 'Xe máy', 'Suzuki GSX-S750', N'Dung tích xylanh: 749cc. Naked bike, động cơ DOHC, công suất 112 mã lực.', '/images/suzuki_gsxs750.jpg', 2023),
--(52, 'Xe máy', 'BMW F750GS', N'Dung tích xylanh: 853cc. Adventure, động cơ 2 xy lanh, hệ thống điều khiển điện tử.', '/images/bmw_f750gs.jpg', 2023),
--(53, 'Xe máy', 'Kawasaki Ninja ZX-6R', N'Dung tích xylanh: 636cc. Sportbike, động cơ 4 thì, thiết kế khí động học.', '/images/kawasaki_zx6r.jpg', 2023),
--(54, 'Xe máy', 'Yamaha XSR700', N'Dung tích xylanh: 689cc. Retro, động cơ 2 xy lanh, thiết kế cổ điển.', '/images/yamaha_xsr700.jpg', 2023),
--(55, 'Xe máy', 'Honda CB500X', N'Dung tích xylanh: 471cc. Adventure, hệ thống phuộc Upside-down, động cơ tiết kiệm nhiên liệu.', '/images/honda_cb500x.jpg', 2023),
--(56, 'Xe máy', 'Kawasaki Z400', N'Dung tích xylanh: 399cc. Naked bike, công nghệ phanh ABS, động cơ DOHC.', '/images/kawasaki_z400.jpg', 2023),
--(57, 'Xe máy', 'Yamaha TMAX 560', N'Dung tích xylanh: 560cc. Xe tay ga, công nghệ phun xăng điện tử, động cơ mạnh mẽ.', '/images/yamaha_tmax560.jpg', 2023),
--(58, 'Xe máy', 'Honda NC750X', N'Dung tích xylanh: 745cc. Adventure, động cơ 2 xy lanh, hệ thống điều chỉnh phuộc.', '/images/honda_nc750x.jpg', 2023),
--(59, 'Xe máy', 'Kawasaki Z900', N'Dung tích xylanh: 948cc. Naked bike, động cơ 4 thì, phuộc hành trình dài.', '/images/kawasaki_z900.jpg', 2023),
--(60, 'Xe máy', 'BMW R nineT', N'Dung tích xylanh: 1170cc. Retro, động cơ Boxer, thiết kế cổ điển.', '/images/bmw_rninet.jpg', 2023),
--(61, 'Xe máy', 'KTM 390 Adventure', N'Dung tích xylanh: 373cc. Adventure, phuộc dài, hệ thống kiểm soát mô-men xoắn.', '/images/ktm_390adventure.jpg', 2023),
--(62, 'Xe máy', 'Yamaha Tracer 700', N'Dung tích xylanh: 689cc. Adventure, động cơ mạnh mẽ, hệ thống phuộc hiệu suất cao.', '/images/yamaha_tracer700.jpg', 2023),
--(63, 'Xe máy', 'Suzuki V-Strom 1050', N'Dung tích xylanh: 1037cc. Adventure, hệ thống kiểm soát lực kéo, động cơ 2 xy lanh.', '/images/suzuki_vstrom1050.jpg', 2023),
--(64, 'Xe máy', 'Honda Rebel 500', N'Dung tích xylanh: 471cc. Cruiser, thiết kế cổ điển, động cơ mạnh mẽ.', '/images/honda_rebel500.jpg', 2023),
--(65, 'Xe máy', 'Kawasaki W800', N'Dung tích xylanh: 773cc. Retro, động cơ 2 xy lanh, thiết kế cổ điển.', '/images/kawasaki_w800.jpg', 2023),
--(66, 'Xe máy', 'Yamaha FZ25', N'Dung tích xylanh: 249cc. Naked bike, thiết kế thể thao, động cơ mạnh mẽ.', '/images/yamaha_fzsfi.jpg', 2023);
