import { Card, Checkbox } from "antd"
import { Link } from "react-router-dom"

type Props = {
    id: string;
    name: string;
}

export const CarRow = ({id, name}: Props) => {
    return(
        <Card style={{ width: "600px" }}>
            <Checkbox>open</Checkbox>
            <Link to={`/${id}`}>{name}</Link>
        </Card>
    )
}