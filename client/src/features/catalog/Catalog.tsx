import React, { useEffect, useState } from "react";
import { IProduct } from "../../app/models/product";

import ProductList from "./ProductList";

const Catalog = () => {
  const [products, setProducts] = useState<IProduct[]>([]);

  useEffect(() => {
    fetch("http://localhost:5000/api/products")
      .then((response) => response.json())
      .then((data) => {
        setProducts(data);
      });
  }, []);
  return (
    <React.Fragment>
      <ProductList products={products} />
    </React.Fragment>
  );
};

export default Catalog;
