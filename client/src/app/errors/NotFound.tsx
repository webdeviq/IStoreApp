import { Button, Container, Divider, Paper, Typography } from "@mui/material";
import { Link } from "react-router-dom";

const NotFound = () => {
  return (
    <Container component={Paper} sx={{ height: 400 }}>
      <Typography gutterBottom variant="h3">
        Oops - we could not find what your looking for
      </Typography>
      <Divider />
      <Button fullWidth component={Link} to="/catalog">
        Go back to shop
      </Button>
    </Container>
  );
};

export default NotFound;
