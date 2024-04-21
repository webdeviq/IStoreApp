import React, { useEffect, useState } from "react";
import { IProduct } from "../../app/models/product";

import ProductList from "./ProductList";
import agent from "../../app/api/agent";
import LoadingComponent from "../../app/layout/LoadingComponent";

const Catalog = () => {
  const [products, setProducts] = useState<IProduct[]>([]);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    agent.Catalog.list()
      .then((products) => setProducts(products))
      .catch((error) => console.log(error))
      .finally(() => setLoading(false));
  }, []);
  if (loading) return <LoadingComponent message="Loading products..." />;
  return (
    <React.Fragment>
      <ProductList products={products} />
    </React.Fragment>
  );
};

export default Catalog;
