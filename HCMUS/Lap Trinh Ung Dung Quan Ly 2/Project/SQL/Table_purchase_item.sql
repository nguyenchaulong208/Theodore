-- Thêm dữ liệu cho bảng PURCHASE_ITEM (Mặt hàng mua)
INSERT INTO [dbo].[PURCHASE_ITEM] 
([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date])
VALUES 
(1, 2, 500000000, 1000000000, 1, N'01/01/2023', 1, N'1000cc', N'2023'),
(2, 1, 300000000, 300000000, 2, N'02/01/2023', 1, N'600cc', N'2023'),
(3, 5, 20000000, 100000000, 23, N'03/01/2023', 6, N'1000cc', N'2023'),
(4, 3, 15000000, 45000000, 45, N'04/01/2023', 3, N'390cc', N'2023'),
(5, 4, 80000000, 320000000, 23, N'05/01/2023', 6, N'1000cc', N'2023');
-- Thêm dữ liệu tương tự cho các mặt hàng mua khác
