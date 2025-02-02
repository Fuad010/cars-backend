import { CarCard } from 'entities/car/car-card'
import styles from './dashboardSeeAllCarsWrapper.module.css'
import { observer } from 'mobx-react-lite'
import { carModel } from 'entities/car'
import { useEffect } from 'react'

export const DashboardSeeAllCarsWrapper = observer(() =>{
    const { store: { getCarList, carListError, carList, isLoading  } } 
    = carModel
    useEffect(() => {
        getCarList();
    }, [])

    if (carListError) {
        return<>{carListError}</>
    }
    return(
        <div className={styles.wrapper}>
            {carList.map((car)=>(
                <CarCard 
                    id={car.id} 
                    brandName={car.brandName} 
                    name={car.name} price={car.price} 
                    mileage={car.mileage} 
                    year={car.year} 
                    engine={car.engine} 
                    image={car.images[0]} 
                />
            ))}
        </div>
    )
})