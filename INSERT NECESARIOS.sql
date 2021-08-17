-- bodega
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('1', 'Olivos', 'A');
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('2', 'Maya', 'A');
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('3', 'Portales', 'A');

-- proveedores
INSERT INTO `sic`.`proveedores` (`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`, `estatus_proveedor`) VALUES ('1', 'Jorge', 'Olivos', '542', '4110', 'A');
INSERT INTO `sic`.`proveedores` (`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`, `estatus_proveedor`) VALUES ('2', 'Josue', 'Maya', '123', '4444', 'A');
INSERT INTO `sic`.`proveedores` (`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`, `estatus_proveedor`) VALUES ('3', 'Wilmer', 'Rosario', '111', '5555', 'A');

-- marcas
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('1', 'Nike', 'A');
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('2', 'Adidas', 'A');
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('3', 'Jordan', 'A');

-- lineas
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('1', 'Linea1', 'A');
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('2', 'Linea2', 'A');
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('3', 'Linea3', 'A');

-- productos
INSERT INTO `sic`.`productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES ('1', 'Zapato', '1', '1', '100', 'A');
INSERT INTO `sic`.`productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES ('2', 'Ropa', '2', '2', '100', 'A');

