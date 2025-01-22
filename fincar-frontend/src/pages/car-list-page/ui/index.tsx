import { Result, Space, Spin } from "antd";
import { carModel, CarRow } from "entities/car";
import { observer } from "mobx-react-lite";
import { useEffect } from "react";

export const CarListPage = observer(() => {
    const { store: { getCarList, isLoading, carListError, carList}, }
     = carModel
     
    useEffect(() => {
        getCarList({});
    }, [])

    if (carListError) {
       return <Result title={carListError}></Result>
    }
    console.log(carList);
    
    return (
        <Space>
            <p>filter</p>
            {isLoading ? (
                <Spin />
            ) : (
                carList.map((car) => (<CarRow key={car.id} name={car.name} id={car.id} />
            )))}
        </Space>
    )
})