import { CarDescription } from 'shared/ui/car-description'
import { carModel } from 'entities/car'
import styles from './carDetailsNames.module.css'
import { observer } from 'mobx-react-lite'
import { useEffect } from 'react'
import { keys } from 'mobx'

interface CarDetailsNamesProps{
    id:string
}

export const CarDetailsNames = observer(({id}:CarDetailsNamesProps) =>{
    const { store: { getCar, car, carListError } } 
    = carModel
    useEffect(()=>{
        getCar(id);
    },[id])
    
    const carDetails: { label: string; value: string }[] = [
        { label: 'Box', value: car?.boxType ?? '' },
        { label: 'Color', value: car?.colorName ?? '' },
        { label: 'Steering Wheel', value: car?.steeringWheelType ?? '' },
        { 
            label: 'Post Created', 
            value: car?.creationDate 
                ? new Date(car.creationDate).toLocaleDateString('en-GB')
                : '' 
        },
        { label: 'Body', value: car?.bodyType ?? '' },
    ];

    return(
        <div className={styles.wrapper}>
            <h1>{car?.brandName} {car?.name}, {car?.engine}, {car?.year} year, {car?.mileage} km</h1>
            <h2>{car?.price} USD</h2>
            <div className={styles.content}>
                {carDetails.map((detail)=>(
                    <CarDescription 
                        key={detail.label} 
                        description={detail.label} 
                        descAnswer={detail.value ?? ''} />
                    ))}
            </div>
        </div>
    )
})