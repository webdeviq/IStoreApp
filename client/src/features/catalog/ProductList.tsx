import { Grid } from "@mui/material";
import { IProduct } from "../../app/models/product";
import ProductCard from "./ProductCard";

interface Props {
  products: IProduct[];
}

const ProductList = ({ products }: Props) => {
  return (
    <Grid spacing={4} container>
      {products.map((product) => (
        <Grid item xs={3} key={product.id}>
          <ProductCard product={product} />
        </Grid>
      ))}
    </Grid>
  );
};

export default ProductList;
